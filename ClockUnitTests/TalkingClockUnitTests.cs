using Talking_Clock;
namespace ClockUnitTests;

[TestClass]
public class GetMins
{
    
 
    [TestMethod]
    public void MinsToText_Should_Return_Tenpast_When_min_is_10()
    {
        // returing result if minute is 10
        int min = 10;
        string rvalue = Talking_Clock.Program.MinsToText(min);
        string correctValue = "Ten past";
        Assert.AreEqual(correctValue, rvalue);
    }

   
    [TestMethod]
    public void MinsToText_Should_Return_Tento_When_min_is_50()
    {
        int min = 50;
        string rvalue = Talking_Clock.Program.MinsToText(min);
        string correctValue = "Ten to";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void MinsToText_Should_Return_Invalid_min_When_min_is_60()
    {
        int min = 60;
        string rvalue = Talking_Clock.Program.MinsToText(min);
        string correctValue = "Invalid min";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void MinsToText_Should_Return_oclock_When_min_is_00()
    {
        int min = 00;
        string rvalue = Talking_Clock.Program.MinsToText(min);
        string correctValue = "o'clock";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void MinsToText_Should_Return_Half_past_When_min_is_30()
    {
        int min = 30;
        string rvalue = Talking_Clock.Program.MinsToText(min);
        string correctValue = "Half past";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void MinsToText_Should_Return_Twenty_Nine_past_When_min_is_29()
    {
        int min = 29;
        string rvalue = Talking_Clock.Program.MinsToText(min);
        string correctValue = "Twenty Nine past";
        Assert.AreEqual(correctValue, rvalue);
    }


    [TestMethod]
    public void MinsToText_Should_Return_One_to_When_min_is_59()
    {
        int min = 59;
        string rvalue = Talking_Clock.Program.MinsToText(min);
        string correctValue = "One to";
        Assert.AreEqual(correctValue, rvalue);
    }

}

[TestClass]
public class GetHours
{
    [TestMethod]
    public void HourToText_Should_Return_Invalid_hour_is_24()
    {
        int hour = 24;
        string rvalue = Talking_Clock.Program.HourToText(hour);
        string correctValue = "Invalid hour";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void HourToText_Should_Return_Fifteen_when_hour_is_15()
    {
        int hour = 15;
        string rvalue = Talking_Clock.Program.HourToText(hour);
        string correctValue = "Three";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void HourToText_Should_Return_Twelve_when_hour_is_12()
    {
        int hour = 00;
        string rvalue = Talking_Clock.Program.HourToText(hour);
        string correctValue = "Twelve";
        Assert.AreEqual(correctValue, rvalue);

    }


    


}


[TestClass]
public class GetTheTime
{
    [TestMethod]
    public void GetTalkingTime_Should_Return_Four_oclock_when_time_is_1600_with_colon()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        string time = "16:00";
        string rvalue = Talking_Clock.Program.GetTalkingTime(time);
        
        string correctValue = "Four o'clock";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void GetTalkingTime_Should_Return_Error_mmhh_when_time_is_1600()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        string time = "1600";
        string rvalue = Talking_Clock.Program.GetTalkingTime(time);

        string correctValue = "Invalid Time Make Sure You Display Answer in the format mm:hh";
        Assert.AreEqual(correctValue, rvalue);
    }


    [TestMethod]
    public void GetTalkingTime_Should_Return_Error_mmhh_when_time_is_160000_with_colon()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        string time = "160:000";
        string rvalue = Talking_Clock.Program.GetTalkingTime(time);

        string correctValue = "Invalid Time Make Sure You Display Answer in the format mm:hh";
        Assert.AreEqual(correctValue, rvalue);
    }


    [TestMethod]
    public void GetTalkingTime_Should_Return_Invalid_hour_when_time_is_2400_with_colon()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        string time = "24:00";
        string rvalue = Talking_Clock.Program.GetTalkingTime(time);

        string correctValue = "Invalid hour";
        Assert.AreEqual(correctValue, rvalue);

    }


    [TestMethod]
    public void GetTalkingTime_Should_Return_Invalid_Time_when_time_is_mmhh_with_colon()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        string time = "mm:hh";
        string rvalue = Talking_Clock.Program.GetTalkingTime(time);

        string correctValue = "Invalid Time, ensure your input time includes numbers";
        Assert.AreEqual(correctValue, rvalue);
    }
}


[TestClass]
public class OutputTheTime
{
    [TestMethod]
    public void OutputTalkingTime_Should_Return_Four_oclock_when_time_is_16_00()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        int min = 16;
        int hour = 00;
        string rvalue = Talking_Clock.Program.OutputTalkingTime(min,hour);

        string correctValue = "Four o'clock";
        Assert.AreEqual(correctValue, rvalue);
    }

    

    [TestMethod]
    public void OutputTalkingTime_Should_Return_Invalid_hour_when_time_is_24_00()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        int min = 24;
        int hour = 00;
        string rvalue = Talking_Clock.Program.OutputTalkingTime(min, hour);

        string correctValue = "Invalid hour";
        Assert.AreEqual(correctValue, rvalue);
    }

    [TestMethod]
    public void OutputTalkingTime_Should_Return_Five_to_Twelve_when_time_is_23_55()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        int min = 23;
        int hour = 55;
        string rvalue = Talking_Clock.Program.OutputTalkingTime(min, hour);

        string correctValue = "Five to Twelve";
        Assert.AreEqual(correctValue, rvalue);
    }


    [TestMethod]
    public void OutputTalkingTime_Should_Return_Invalid_min_when_time_is_21_60()
    {
        //"Invalid Time Make Sure You Display Answer in the format mm:hh";
        //"Invalid Time, ensure your input time includes numbers";

        int min = 21;
        int hour = 60;
        string rvalue = Talking_Clock.Program.OutputTalkingTime(min, hour);

        string correctValue = "Invalid min";
        Assert.AreEqual(correctValue, rvalue);
    }

}
