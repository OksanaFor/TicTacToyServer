using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
  
    public class StatisticTest
    {
        [Fact]
        public void GetAllStatistic()
        {
            var statistic = new List<UserStatistics>
            {
                new UserStatistics
                {
                    Drow = 2
                    
                }

            }.AsQueryable();

            var mockStatistic = new Mock<DbSet<UserStatistics>>();


            mockStatistic.As<IQueryable<UserStatistics>>().Setup(m => m.Provider).Returns(statistic.Provider);
            mockStatistic.As<IQueryable<UserStatistics>>().Setup(m => m.Expression).Returns(statistic.Expression);
            mockStatistic.As<IQueryable<UserStatistics>>().Setup(m => m.ElementType).Returns(statistic.ElementType);
            mockStatistic.As<IQueryable<UserStatistics>>().Setup(m => m.GetEnumerator()).Returns(() => statistic.GetEnumerator());


            var context = new Mock<ITicTacToyEntities>();
            context.Setup(c => c.UserStatistics).Returns(mockStatistic.Object);

            Assert.NotEqual(3, context.Object.Users.Count());
        }
    }
}
