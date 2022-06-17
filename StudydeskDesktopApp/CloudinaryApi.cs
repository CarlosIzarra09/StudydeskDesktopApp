using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudydeskDesktopApp
{
    public class CloudinaryApi
    {
        Account account;

        public CloudinaryApi()
        {
            this.account = new Account(
                "dwhagi5eg",
                "765731732897288",
                "wjtVZm823OpjWtnV_wO-_WiyKg0"); ;
        }

        public string uploadImage(OpenFileDialog file)
        {
            Cloudinary cloudinary = new Cloudinary(account);
            cloudinary.Api.Secure = true;

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName)
            };

            var uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult.SecureUrl.AbsoluteUri;
        }
    }
}
