namespace TransfocusBack.Models.DTO
{
    public class JsonResponse
    {
        public Boolean success { get; set; }
        public string? errorMessage { get; set; }
        public dynamic? data { get; set; }
        public int totalCount { get; set; }
    }
}
