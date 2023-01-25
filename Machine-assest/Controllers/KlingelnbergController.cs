using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Machine_assest.Controllers
{
    [Route("api/KlingelnbergController")]
    [ApiController]
    public class KlingelnbergController : ControllerBase
    {
        string[] FilePath = System.IO.File.ReadAllLines(@"C:\Users\kurh_rut\Desktop\C_Sharp_tutorials\Machine-assest\Resource\file.txt");
    }
}
