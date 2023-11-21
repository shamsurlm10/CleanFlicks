using CleanMovie.API.Controllers.Base;
using CleanMovie.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    public class DemoEmailController : BaseApiController
    {
        private readonly IEmailService _emailService;

        public DemoEmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        public async Task<ActionResult> SendMail([FromQuery] int code)
        {
            if (code == 1)
            {
                var reciever = "shamsurlm10@gmail.com";
                var subject = "Demo Email for test";
                var body = "Hello, i am sending this email for test purpose. Do not reply to this mail. Thanks for the co-operting";

                await _emailService.SendEmailAsync(reciever, subject, body);
                return Ok("Sent Successfully");
            }
            else
                return BadRequest("Invalid");
        }
    }
}
