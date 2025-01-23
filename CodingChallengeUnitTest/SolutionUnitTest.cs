using CodingChallenge;

namespace CodingChallengeUnitTest
{
    public class SolutionUnitTest
    {
        [Theory]
        [InlineData("2#", "A")]             
        [InlineData("22#", "B")]          
        [InlineData("222#", "C")]     
        [InlineData("33#", "E")]    
        [InlineData("227*#", "B")]    
        [InlineData("222 2 22#", "CAB")] 
        [InlineData("4433555 555666#", "HELLO")]   
        [InlineData("8 88777444666*664#", "TURING")]   
        [InlineData("83377778#", "TEST")]   
        [InlineData("6 666 666 66#", "MOON")]       
        [InlineData("4666 6663#", "GOOD")]        
        [InlineData("4666 666*3#", "GOD")]
        [InlineData("33663***33663#", "END")]  
        public void ProcessInput_OldPhonePad_ReturnsExpectedResult(string input, string expected)
        {

            // Arrange & Act
            var result = Solution.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}