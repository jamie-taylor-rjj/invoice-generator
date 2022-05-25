namespace InvoiceGenerator.ViewModels
{
    public class ClientNameViewModel
    {
        // It'll be easier to ratify the client chosen in the drop down against the
        // list of clients in the database later if we do this now
        public Guid Id { get; set; }
        public string ClientName { get; set; }

        public static ClientNameViewModel FromDbModel(InvoiceGenerator.Domain.Client dbModel)
        {
            return new ClientNameViewModel
            {
                ClientName = dbModel.ClientName,
                Id = dbModel.ClientId
            };
        }
    }
}
