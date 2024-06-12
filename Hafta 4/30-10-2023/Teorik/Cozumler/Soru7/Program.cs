using Soru7;

List<SoftwareSpecialist> team = new List<SoftwareSpecialist>();

foreach (SoftwareSpecialist item in team)
{
    if (item is SoftwareTester)
    {
        SoftwareTester tester = item as SoftwareTester;
        tester.TesterOzellik = "Tester Özellik";
    }
}