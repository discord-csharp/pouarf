using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pouarf.Helpers
{
    public static class MockData
    {
        public static readonly DateTime DateBase = new DateTime(1940, 1, 1);

        public static readonly string[] PhoneLocations = { "Home", "Work", "Mobile" };
        public static readonly string[] PhysicalLocations = { "Home", "Work" };

        public static readonly string[] EmailHosts = { "yahoo", "gmail", "aol", "hotmail", "outlook", "msn" };

        public static readonly string[] StreetKinds = { "Ln", "Rd", "Ave", "St", "Blvd" };

        public static readonly string[] Countries = {"Afghanistan", "Åland Islands", "Albania", "Algeria", "American Samoa", "Andorra",
                                                     "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia",
                                                     "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin",
                                                     "Bermuda", "Bhutan", "Bolivia", "Bonaire, Sint Eustatius and Saba", "Bosnia and Herzegovina", "Botswana",
                                                     "Bouvet Island", "Brazil", "British Indian Ocean Territory", "Brunei", "Bulgaria", "Burkina Faso", "Burundi",
                                                     "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile",
                                                     "China", "Christmas Island", "Cocos (Keeling) Islands", "Colombia", "Comoros", "Wallis and Futuna",
                                                     "Congo, the Democratic Republic of the", "Cook Islands", "Costa Rica", "Croatia", "San Marino",
                                                     "Iran", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jersey", "Jordan", "Kazakhstan",
                                                     "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon",
                                                     "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macao", "Macedonia", "Madagascar",
                                                     "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius",
                                                     "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco",
                                                     "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Samoa",
                                                     "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore",
                                                     "Sint Maarten", "Slovakia", "Slovenia", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan",
                                                     "Svalbard and Jan Mayen Islands", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan",
                                                     "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey",
                                                     "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates",
                                                     "United Kingdom (Great Britain)", "United States", "United States Minor Outlying Islands", "Uruguay",
                                                     "Uzbekistan", "Vanuatu", "Venezuela", "Viet Nam"};

        public static readonly string[] Cities = { "Mukilteo", "Fairfield", "Chicago", "Hernando", "Irving", "Baltimore", "Kingston", "Burlington",
                                                    "Harrison", "Newton Center", "Littleton", "Bloomington", "San Ramon", "Downers Grove", "Circleville", "Oxnard", "Gulfport", "Portland",
                                                    "Houston", "Greenbank", "Somerset", "Sidman", "Minneapolis", "Manchester", "Canton", "The Bronx", "San Francisco", "Saluda", "San Jose",
                                                    "Santa Clara", "Sunnyvale", "Washington", "Harrisburg", "Stafford", "Newington", "Vienna", "Cambridge", "Boston", "South Harwich",
                                                    "Worcester", "Tampa", "Lake Wales", "Saint Petersburg", "Kyle", "Pomona", "Covina", "Edmonds", "Kirkland", "White Plains", "Waynesboro",
                                                    "Buffalo", "New York", "Ridgewood", "Utica", "Port Washington", "Brecksville", "Streetsboro", "Hartford", "Nashville", "Chester",
                                                    "Richmond", "Jacksonville", "Kissimmee", "Clinton", "Denver", "Fort Worth", "Brandon", "Dover", "Union Township", "Nazareth", "Pine Brook",
                                                    "Edison", "Redwood City", "Arvada", "Pineville", "Ponte Vedra Beach", "Sarasota", "Jackson", "Nacogdoches", "Tomball", "McKinney",
                                                    "Little Rock", "Dallas", "Halethorpe", "Crofton", "Northbrook", "Palatine", "New Hyde Park", "Phoenix", "Northville", "St Louis",
                                                    "Lafayette", "Castle Rock", "Windsor", "Laurel", "Collegeville", "Twinsburg", "Getzville", "Richfield", "Rochester", "Lorton",
                                                    "Manassas", "Virginia Beach", "Waldorf", "Ashburn", "Seattle", "Woodbridge", "Verona", "Bakersfield", "Scranton", "Riverside", "Gardena",
                                                    "Bakersfield", "Fontana", "Los Angeles", "Sacramento", "Bonham", "Keller", "Orlando", "Largo", "Austin", "Atlanta", "Salem", "Stockbridge",
                                                    "Monroe Township", "Lakewood", "San Diego", "Spring Valley", "Reseda", "Oak Brook", "Novi", "Miami", "Fort Lauderdale", "Littleton",
                                                    "Southern Pines", "Grantville", "Honesdale", "Philadelphia", "Coatesville", "Kennesaw", "Irvine", "Newbury Park", "Ontario",
                                                    "Manhattan Beach", "San Mateo", "Westlake Village", "Covington", "Wichita", "Canton", "Euless", "New Orleans", "Garland",
                                                    "Poughkeepsie", "Mechanicsville", "Sterling", "Temple Hills", "Glen Allen", "Hopkins", "Jersey City", "Parsippany", "Wanaque" };

        public static readonly string[] Ipsum = { "alias", "consequatur", "aut", "perferendis", "sit", "voluptatem", "accusantium",
                                                  "doloremque", "aperiam", "eaque", "ipsa", "quae", "ab", "illo", "inventore", "veritatis",
                                                  "quasi", "architecto", "beatae", "vitae", "dicta", "sunt", "explicabo", "aspernatur",
                                                  "aut", "odit", "aut", "fugit", "sed", "quia", "consequuntur", "magni", "dolores", "eos",
                                                  "qui", "ratione", "voluptatem", "sequi", "nesciunt", "neque", "dolorem", "ipsum", "quia",
                                                  "dolor", "sit", "amet", "consectetur", "adipisci", "velit", "sed", "quia", "non", "numquam" };

        public static readonly string[] FirstNames = { "Ivy", "Raya", "Maile", "Ali", "Whilemina", "Paula", "Cameron", "Nelle",
                                                       "Lana", "Gavin", "Xena", "Erica", "Moses", "Clio", "Rose", "Ross", "Knox",
                                                       "Lois", "Cheryl", "Noble", "Nash", "Kellie", "Cullen", "Briar", "Ima",
                                                       "Troy", "Flynn", "Lisandra", "Lacy", "Bo", "Brennan", "Rylee", "Vladimir",
                                                       "Knox", "Ingrid", "Angelica", "Sean", "Demetria", "Susan", "Edan", "Rachel",
                                                       "Alexander", "Colette", "Caryn", "Justin", "Bevis", "Tasha", "Imelda", "Lance",
                                                       "Audra", "Jacob", "TaShya", "Dara", "Calvin", "Sydney", "Nathan", "Hayfa", "Patricia",
                                                       "Ingrid", "Angela", "Rhoda", "Robin", "Sierra", "Anne", "Kirsten", "Solomon", "Kylee",
                                                       "Valentine", "Boris", "Elijah", "Nicole", "Yuri", "Vera", "Rudyard", "Joshua", "Ebony",
                                                       "Caleb", "Buffy", "Melvin", "MacKenzie", "Whoopi", "Kellie", "Victor", "Hayley",
                                                       "Melissa", "Doris", "Farrah", "Shea", "Kelsie", "Mariko", "Halee", "Irma", "Isadora",
                                                       "Ramona", "Farrah", "Kaye", "Sigourney", "Rinah", "Alma", "Lane" };

        public static readonly string[] LastNames = { "Maldonado", "Waters", "Wilcox", "Berger", "Massey", "Waller", "Emerson", "Daugherty",
                                                      "Conrad", "Langley", "Mcleod", "Solomon", "Miller", "Mejia", "Silva", "Preston",
                                                      "Rios", "Pearson", "Wheeler", "Snyder", "Blevins", "Bridges", "Rodriguez", "Barrett",
                                                      "Guthrie", "Melendez", "Gregory", "Durham", "Marks", "Nielsen", "Rosales", "Riley",
                                                      "Stokes", "Mann", "Patterson", "Smith", "Byrd", "Adkins", "Combs", "Tillman", "Holt",
                                                      "Mays", "Elliott", "Gonzalez", "Stephens", "Shaw", "Lambert", "Rush", "Barron", "Hodges",
                                                      "Mayo", "Townsend", "Parsons", "Fitzgerald", "Mason", "Blackwell", "Figueroa", "Peck",
                                                      "Castaneda", "Dominguez", "Sheppard", "Stein", "Brown", "Figueroa", "Mosley", "Mcdaniel",
                                                      "Shields", "Lang", "Moreno", "Christensen", "Holmes", "Bentley", "Howell", "Rios",
                                                      "Browning", "Barrett", "Sawyer", "Vazquez", "Bright", "Pugh", "Aguirre", "Jones",
                                                      "Gaines", "Craft", "Madden", "Hardy", "Hicks", "Yang", "Rich", "Nieves", "Lynn", "Rhodes",
                                                      "Mckay", "Powers", "Roy", "Suarez", "Kinney", "Bauer", "Gilmore", "Cook" };
    }
}
