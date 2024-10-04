using Newtonsoft.Json;
HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("http://datapoint.metoffice.gov.uk/public/data/val/wxfcs/all/json/sitelist?key=bf5f5026-1766-49c3-9d9f-aff7ae95a8e6");
string sitelist = await response.Content.ReadAsStringAsync();
dynamic sitelistJson = JsonConvert.DeserializeObject(sitelist);

foreach (dynamic site in sitelistJson.Locations.Location)
{
    Console.WriteLine("Site Name: " + site.name);
    Console.Write("Site ID:" + site.id);
    Console.WriteLine("\n");
}

Console.WriteLine("Please enter your chosen ID number");
string choiceId;
choiceId = Console.ReadLine();

foreach (dynamic site in sitelistJson.Locations.Location)
{
    choiceId = site.id;
    Console.WriteLine("ID choice: " + choiceId);
    Console.WriteLine("\n");
}