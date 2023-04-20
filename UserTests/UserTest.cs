using System.Security.Cryptography.X509Certificates;
using UserNamespace;

namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void User_IsCreated_WithCorrectPropertyValues()
        {
            var user1 = new User("Skylar Sandler", "skylarbsandler@gmail.com");

            Assert.Equal("Skylar Sandler", user1.Name);
            Assert.Equal("skylarbsandler@gmail.com", user1.Email);
        }

        [Fact]
        public void User_IsSetupComplete_Correctly()
        {
            var user1 = new User("Skylar Sandler", "skylarbsandler@gmail.com");
            user1.CreatePassword("skylarbsandler@gmail.com", "Launch2303");
            var setUp = user1.IsSetupComplete();

            Assert.Equal(true, user1.IsSetupComplete());

            var user2 = new User("Scott Ganz", "sganz@gmail.com");
            var setUp2 = user2.IsSetupComplete();
            Assert.Equal(false, user2.IsSetupComplete());
        }

        [Fact]
        public void User_CreatePassword_SuccessfullyCreated()
        {
            var user1 = new User("Skylar Sandler", "skylarbsandler@gmail.com");
            user1.CreatePassword("skylarbsandler@gmail.com", "Launch2303");

            var confirmation = "Password Created";

            Assert.Equal("Launch2303", user1.Password);
            Assert.Equal("Password Created", confirmation);
        }

        [Fact]
        public void User_LogIn_CorrectlyLogsUserIn()
        {
            var user1 = new User("Skylar Sandler", "skylarbsandler@gmail.com");
            user1.CreatePassword("skylarbsandler@gmail.com", "Launch2303");

            Assert.Equal("Logged In", user1.LogIn("Launch2303"));
        }

        [Fact]
        public void User_LogOut_CorrectlyLogsUserOut()
        {
            var user1 = new User("Skylar Sandler", "skylarbsandler@gmail.com");

            user1.LogOut();

            Assert.Equal(false, user1.IsLoggedIn);
        }
    }
}