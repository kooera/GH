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
            CmdHelper cmd = new CmdHelper(@"F:\Code-Product\mkcommon\Log");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("F: &");
            stringBuilder.Append(@"cd F:\Code-Product\mkcommon");
            stringBuilder.Append("\n");
            stringBuilder.Append("dotnet build MKCommon.sln ");

            cmd.Execute(stringBuilder.ToString());

            return Guid.NewGuid().ToString();
        }

        [HttpGet]
        public string nuosoo()
        {
            CmdHelper cmd = new CmdHelper(@"F:\Code-Product\mkcommon\Log");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("F: &");
            stringBuilder.Append(@"cd F:\Code-Product\mkcommon");
            stringBuilder.Append("\n");
            stringBuilder.Append("dotnet build MKCommon.sln ");

            cmd.Execute(stringBuilder.ToString());

            return Guid.NewGuid().ToString();
        }
    }
}