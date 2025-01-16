namespace dotNetCources.DTO.Authorization
{
    public class PasswordResetDto
    {
        public string Uuid { get; set; }
        public string OTP { get; set; }
        public string NewPassword { get; set; }
    }
}
