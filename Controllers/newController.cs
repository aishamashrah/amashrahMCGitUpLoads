
using Microsoft.AspNetCore.Mvc;

namespace amashrahMCGitUpLoads.Controllers;

[ApiController
]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
   [HttpGet]
    [Route("Min1/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}";
    }  
    [HttpGet]
    [Route("addingNumbers")]

    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }
    public class NewController : ControllerBase
{
   [HttpGet]
    [Route("GreaterthanorlessThan")]
    public string GreaterthanorlessThan(){
     return "num1 is greater than num2" ;  
    }
}
public class NewController : ControllerBase
{
   [HttpGet]
    [Route("MiniCh5")]

    public string MadLib()
    {
        return " You will be asked  questions andthat will make a story";
    }
}
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh6")]

    public string OrE()
    {
        return " The user will pick two numbers output will say if its odd or even";
    }
}
public class NewController : ControllerBase
{
[HttpGet]
    [Route("ReverseIt")]

    public string ReverseIt()
    {
        return " it will reverse the users input";
    }
}
public class NewController : ControllerBase
{
    
    [HttpGet]
    [Route("magic8")]
    public string putOut() {
        return "It will throw out random  answer for the player";
    }
   
}
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("restaurantpicker")]

    public string restaurantPicker()
    {
        return "it will choose 3 different types of food for you it will also chooes a random place for you to eat in that catagory";
    } 
}
}