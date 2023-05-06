using BLL;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAuthenticateTrue()
        {
            string inputUserName = "052203006901";
            string inputPassword = "0855004714";


            List<string> output= new List<string>();
            output.Add("ADMIN");
            output.Add("d71feb4b-a5b1-47c0-bf29-5f8b934e7d96");
            output.Add("Duong Trung Nguyen");
            Respond expected = new Respond(true, output, "Login Successfully!");



            Respond realOutput = Authentication.LoginAuth(inputUserName, inputPassword);
            
            Assert.AreEqual(expected.getStatus(), realOutput.getStatus());
            Assert.AreEqual(expected.getData(), realOutput.getData());
            Assert.AreEqual(expected.getDescription(), realOutput.getDescription());
        }
    }
}