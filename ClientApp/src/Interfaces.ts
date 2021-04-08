interface HomeAddress {
  Address: string;
  City: string;
}

interface City {
  Name: string;
  CountryRegion: string;
  Region: string;
}

interface AddressInfo {
  Address: string;
  City: City;
}

interface Person {
  UserName: string;
  FirstName: string;
  LastName: string;
  MiddleName: string;
  Gender: string;
  Age: string;
  Emails: string[];
  FavoriteFeature: string;
  Features: string[];
  AddressInfo: AddressInfo[];
  HomeAddress: HomeAddress;
}
