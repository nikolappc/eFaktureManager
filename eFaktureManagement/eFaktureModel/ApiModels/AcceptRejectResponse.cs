namespace eFaktureManagement.ApiModels
{
    public abstract class AcceptRejectResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string httpStatus { get; set; }
    }
}
