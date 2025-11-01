namespace RouteG04.PL.ViewModel.DepartmentViewModel
{
    public class DepartmentEditViewModel
    {
        public string Name { get; set; } = null!;

        public string Code { get; set; } = null!;

        public string? description { get; set; }

        public DateTime? DateOfCreation { get; set; }
    }
}
