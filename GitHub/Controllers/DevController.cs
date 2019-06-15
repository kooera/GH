using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using Vli.Helper;

namespace GitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevController : ControllerBase
    {
        [HttpPost]
        public string nuosoon()
        {
            CmdHelper cmd = new CmdHelper();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(@"cd C:\Code\Vli\Vli.sln");
            stringBuilder.Append("\n");
            stringBuilder.Append("dotnet build");

            cmd.Execute(stringBuilder.ToString());

            return Guid.NewGuid().ToString();
        }

        [HttpGet]
        public string nuosoo()
        {
            CmdHelper cmd = new CmdHelper();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(@"cd C:\Code\Vli\Vli.sln");
            stringBuilder.Append("\n");
            stringBuilder.Append("dotnet build");

            cmd.Execute(stringBuilder.ToString());

            return Guid.NewGuid().ToString();
        }
    }
}