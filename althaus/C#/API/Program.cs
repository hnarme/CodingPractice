using Newtonsoft.Json;
HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("http://datapoint.metoffice.gov.uk/public/data/val/wxfcs/all/json/sitelist?key=bf5f5026-1766-49c3-9d9f-aff7ae95a8e6");
string sitelist = await response.Content.ReadAsStringAsync();
dynamic sitelistJson = JsonConvert.DeserializeObject(sitelist);
Console.WriteLine(sitelistJson.Locations.Location[0].name);
