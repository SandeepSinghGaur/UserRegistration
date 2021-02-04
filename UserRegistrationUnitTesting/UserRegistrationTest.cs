using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationValidation;

namespace UserRegistrationUnitTesting
{
    [TestClass]
    public class UserRegistrationTest
    {
        //<Summary>
        // Validate First name Which should has first letter Capital
        //<Summary>
        [TestMethod]
        public void GivenFirstName_WhenValidate_ReturnTrue()
        {
            bool isValid = RegexValidation.FirstNameMatch("Sandeep");
            Assert.IsTrue(isValid);
        }
        //<Summary>
        // Validate Last name Which should has first letter Capital
        //<Summary>
        [TestMethod]
        public void GivenLastName_WhenValidate_ReturnTrue()
        {
            bool isValid = RegexValidation.LastNameMatch("Singh");
            Assert.IsTrue(isValid);
        }
        //<Summary>
        // Validate Email Address which should contain xyz.acc@bl.co.in format
        //<Summary>
        [TestMethod]
        public void GivenEmailPattern_WhenValidate_ReturnTrue()
        {
            bool isValid = RegexValidation.EmailMatch("Sandeep.singh@bl.co.in");
            Assert.IsTrue(isValid);
        }
        //<Summary>
        // Validate Mobile Number Which start county code(91) and first letter start with 9 or 8 or 7.
        //<Summary>
        [TestMethod]
        public void GivenMobleNumber_WhenValidate_ReturnTrue()
        {
            bool isValid = RegexValidation.MobileNumberMatch("91 9140401246");
            Assert.IsTrue(isValid);
        }
        //<Summary>
        // Validate Password should Contain atleast eight Character
        //<Summary>
        [TestMethod]
        public void GivenPasswordSampleOne_WhenTestingValidation_ReturnTure()
        {
            bool isValid = RegexValidation.PasswordMatch("SandeepSingh");
            Assert.IsTrue(isValid);
        }
        //<Summary>
        // Validate pasword should Contain atleat 8 char 
        //<Summary>
        [TestMethod]
        public void GivenPasswordSampleTwo_WhenTestingValidation_ReturnTure()
        {
            bool isValid = RegexValidation.PasswordMatch02("Sandeep26nas");
            Assert.IsTrue(isValid);
        }
        //<Summary>
        // Validate Password should contain one numeric Character
        //<Summary>
        [TestMethod]
        public void GivenPasswordSamplethree_WhenTestingValidation_ReturnTure()
        {
            bool isValid = RegexValidation.PasswordMatch03("Sandeep3Singh");
            Assert.IsTrue(isValid);
        }
        //<Summary>
        // Validate Password should contain one special Character
        //<Summary>
        [TestMethod]
        public void GivenPasswordSampleFour_WhenTestingValidation_ReturnTure()
        {
            bool isValid = RegexValidation.PasswordMatch04("Sandeep@26nas");
            Assert.IsTrue(isValid);
        }
    }
}
