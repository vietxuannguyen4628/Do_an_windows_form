using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WindowsForm.ChucNang
{
    public class SpeedSMSService
    {
        private readonly string apiKey;
        private readonly string senderName;

        public SpeedSMSService(string apiKey, string senderName = "")
        {
            this.apiKey = apiKey;
            this.senderName = senderName;
        }

        public async Task<(bool success, string message)> SendSMS(string phone, string content)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Cấu hình API
                    client.DefaultRequestHeaders.Add("Authorization", apiKey);

                    // Chuẩn hóa số điện thoại
                    phone = phone.TrimStart('0');
                    if (!phone.StartsWith("84"))
                    {
                        phone = "84" + phone;
                    }

                    // Chuẩn bị dữ liệu
                    var data = new Dictionary<string, string>
                {
                    {"to", phone},
                    {"content", content},
                    {"sms_type", "2"},  // 2 for advertising
                    {"sender", senderName}
                };

                    // Gửi request
                    var response = await client.PostAsync(
                        "https://api.speedsms.vn/index.php/sms/send",
                        new FormUrlEncodedContent(data)
                    );

                    var result = await response.Content.ReadAsStringAsync();
                    return (response.IsSuccessStatusCode, result);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
