using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;

namespace Test
{
    public class UsersTest
    {
        [Fact]
        public void GetAllUsers()
        {
            var users = new List<User>
            {
                new User
                    {
                        Id = 1,
                        Email = "Test",
                        Login = "Test",
                        Password= "Test"
                    },
                new User
                    {
                        Id = 2,
                        Email = "Test",
                        Login = "Test",
                        Password= "Test"
                    },
                new User
                    {
                        Id = 3,
                        Email = "Test",
                        Login = "Test",
                        Password= "Test"
                }
            }.AsQueryable();

            var mockUsers = new Mock<DbSet<User>>();


            mockUsers.As<IQueryable<User>>().Setup(m => m.Provider).Returns(users.Provider);
            mockUsers.As<IQueryable<User>>().Setup(m => m.Expression).Returns(users.Expression);
            mockUsers.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(users.ElementType);
            mockUsers.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(() => users.GetEnumerator());


            var context = new Mock<ITicTacToyEntities>();
            context.Setup(c => c.Users).Returns(mockUsers.Object);

            Assert.Equal(3, context.Object.Users.Count());

            /*
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(c => c.Users.GetAll(null)).Returns(mockSet.Object);

            var mapper = new Mock<IMapper>();

            UserService userService = new UserService(unitOfWork.Object, mapper.Object);

            var users = userService.GetAll();
            Assert.Equal(1, users.Count()); 
            */
            /*
            var context = Mock.Create<TicTacToyEntities>();

            var unitOfWork = Mock.Create<UnitOfWork>(Constructor.NotMocked);
            var mapper = Mock.Create<Mapper>();
            //var mockUserRepository = Mock.Create<BaseRepository<User, int>>();

            Mock.Arrange(() => unitOfWork.Users.GetAll(null))
                .Returns(new List<User>
                {
                    new User
                    {
                        Id = 1,
                        Email = "Test",
                        Login = "Test",
                        Password= "Test"
                    }
                });


            var contactManager = new UserService(unitOfWork, mapper);


            var users = contactManager.GetAll();
            Assert.Equal(1, users.Count());*/
        }
    }
}