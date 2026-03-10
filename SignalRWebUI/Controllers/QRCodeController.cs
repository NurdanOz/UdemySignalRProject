using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;

namespace SignalRWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(string value)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                QRCodeGenerator createQRCode = new QRCodeGenerator();
                QRCodeData squareCode = createQRCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(squareCode))
                {
                    
                    using (Bitmap image = qrCode.GetGraphic(10))
                    {
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                        ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
                return View();
        }
    }
}
