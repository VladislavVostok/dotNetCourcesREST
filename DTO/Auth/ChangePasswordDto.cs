namespace dotNetCources.DTO.Authorization
{
    public class ChangePasswordDto
    {
        public string UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
