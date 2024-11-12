using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;
using WebApplication4.Data;
using WebApplication4.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FalelungContext _context;
        public HomeController(ILogger<HomeController> logger, FalelungContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadExcel1()
        {
            //  var data = _context.HouseOwnerDetails.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadExcel1(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var filepath = Path.Combine(uploadsFolder, file.FileName);
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using (var stream = System.IO.File.Open(filepath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        DataTable sheet1 = result.Tables[0];
                        DataTable sheet2 = result.Tables[1];
                        DataTable sheet3 = result.Tables[2];
                        DataTable sheet4 = result.Tables[3];
                        DataTable sheet5 = result.Tables[4];



                        if (!sheet1.Columns.Contains("HouseOwnerId"))
                        {
                            sheet1.Columns.Add("HouseOwnerId", typeof(int));
                        }

                        var houseOwnerDetails = new List<HouseOwnerDetail>();
                        var houseOwnerCountryGroup = new List<HouseOwnerCountryGroup>();
                        var houseOwnerAbdhiGroup = new List<HouseOwnerAbdhiGroup>();
                        var movedFamilyMemberDetails = new List<MovedFamilyMemberDetail>();
                        var populationDetail = new List<PopulationDetail>();
                        var populationAgeGroup = new List<PopulationDetailAgeGroup>();
                        var populationCasteGroup = new List<PopulationDetailCasteGroup>();
                        var populationOccupationGroup = new List<PopulationDetailOccupationGroup>();
                        var economicDetails = new List<EconomicDetail>();
                        var economicDetailTechnicalSkillGroups = new List<EconomicDetailTechnicalSkillGroup>();
                        var agricultureDetails = new List<AgricultureDetail>();
                        var agricultureDetailAnimals = new List<AgricultureDetailAnimalGroup>();
                        var agricultureProductDetails = new List<AgricultureProductDetail>();
                        var healthDetails = new List<HealthDetail>();
                        var healthChronicGroups = new List<HealthDetailChronicDiseaseGroup>();
                        var healthDisabiltyTypeGroups = new List<HealthDetailDisabilityTypeGroup>();
                        var healthDisabiltyCardGroups = new List<HealthDetailDisabilityCardGroup>();
                        var healthDisabilityReasons = new List<HealthDetailDisabilityReasonGroup>();
                        var educationDetails = new List<EducationDetail>();
                        var educationDetailSchoolGroups = new List<EducationDetailSchoolGroup>();
                        var educationalLevelGroups = new List<EducationEducationalLevelGroup>();
                        var waterDetails = new List<WaterDetail>();
                        var houseDetails = new List<HouseDetail>();
                        var multiSectors = new List<MultisectoralNutritionAndExtension>();
                        var houseOwnerFamilies = new List<HouseOwnerFamilyDetail>();
                        var pregnancyDetails = new List<PregnancyDetail>();
                        var sleepMotherDetails = new List<SleepMotherDetail>();

                        var balBibahaDetails = new List<BalBibaha>();

                        //HouseOwner Details
                        foreach (DataRow row in sheet1.Rows)
                        {
                            if (row["१.घरमुलीको नाम थर"] != DBNull.Value)
                            {
                                var houseownerdetail = new HouseOwnerDetail()
                                {
                                    Name = row["१.घरमुलीको नाम थर"] != DBNull.Value ? row["१.घरमुलीको नाम थर"].ToString() : string.Empty,
                                    Type = row["२.घरमुली"] != DBNull.Value ? row["२.घरमुली"].ToString() : string.Empty,
                                    WardNo = row["६. नया वार्ड नं"] != DBNull.Value ? Convert.ToInt32(row["६. नया वार्ड नं"]) : 0,
                                    Address = row["७.  बस्ती / गाउ / टोलको नाम"] != DBNull.Value ? row["७.  बस्ती / गाउ / टोलको नाम"].ToString() : string.Empty,
                                    HouseNo = row["८. घर नं"] != DBNull.Value ? row["८. घर नं"].ToString() : string.Empty,
                                    TotalFamilyCount = row["१.  जम्मा परिवार संख्या"] != DBNull.Value ? Convert.ToInt32(row["१.  जम्मा परिवार संख्या"]) : 0,
                                    MaleFamilyCount = row["१. १  पुरुष"] != DBNull.Value ? Convert.ToInt32(row["१. १  पुरुष"]) : 0,
                                    FemaleFamilyCount = row["१. २ महिला"] != DBNull.Value ? Convert.ToInt32(row["१. २ महिला"]) : 0,
                                    OtherFamilyCount = row["१. ३ तेस्रो लिंगी"] != DBNull.Value ? Convert.ToInt32(row["१. ३ तेस्रो लिंगी"]) : 0,
                                    TogetherCount = row["२.  संगै बस्ने संख्या"] != DBNull.Value ? Convert.ToInt32(row["२.  संगै बस्ने संख्या"]) : 0,
                                    TogetherMaleCount = row["२.१  पुरुष"] != DBNull.Value ? Convert.ToInt32(row["२.१  पुरुष"]) : 0,
                                    TogetherFemaleCount = row["२.२ महिला"] != DBNull.Value ? Convert.ToInt32(row["२.२ महिला"]) : 0,
                                    TogetherOtherCount = row["२.३ तेस्रो लिंगी"] != DBNull.Value ? Convert.ToInt32(row["२.३ तेस्रो लिंगी"]) : 0,
                                    ResidingCount = row["३.  न.पा. बाहिर अन्य ठाउमा बस्नेको संख्या"] != DBNull.Value ? Convert.ToInt32(row["३.  न.पा. बाहिर अन्य ठाउमा बस्नेको संख्या"]) : 0,
                                    ResidingMaleCount = row["३. १ पुरुष"] != DBNull.Value ? Convert.ToInt32(row["३. १ पुरुष"]) : 0,
                                    ResidingFemaleCount = row["३. २  महिला"] != DBNull.Value ? Convert.ToInt32(row["३. २  महिला"]) : 0,
                                    ResidingOtherCount = row["३. ३तेस्रो लिंगी"] != DBNull.Value ? Convert.ToInt32(row["३. ३तेस्रो लिंगी"]) : 0,
                                    ResidingAbroadCount = row["४.  विदेशमा बस्नेको संख्या"] != DBNull.Value ? Convert.ToInt32(row["४.  विदेशमा बस्नेको संख्या"]) : 0,
                                    ResidingAbroadMaleCount = row["४. १ पुरुष"] != DBNull.Value ? Convert.ToInt32(row["४. १ पुरुष"]) : 0,
                                    ResidingAbroadFemaleCount = row["४. २ महिला"] != DBNull.Value ? Convert.ToInt32(row["४. २ महिला"]) : 0,
                                    ResidingAbroadOtherCount = row["४. ३तेस्रो लिंगी"] != DBNull.Value ? Convert.ToInt32(row["४. ३तेस्रो लिंगी"]) : 0,
                                    HouseTypeId = GetHouseTypeId(row["११. घरको प्रकार तथा किसिम"] != DBNull.Value ? row["११. घरको प्रकार तथा किसिम"].ToString().Trim() : string.Empty),
                                    IsUnEmployedMember = MapBooleanValue(row["१३. सिपयुक्त व्यक्ति बेरोजगार बसेको"]?.ToString()),
                                    SkillTypeId = GetSkillTypeId(row["१३.१ व्यक्तिको सिप"] != DBNull.Value ? row["१३.१ व्यक्तिको सिप"].ToString().Trim() : string.Empty),
                                    LandAnna = row["१४. जग्गा जमिन (आना)"] != DBNull.Value ? row["१४. जग्गा जमिन (आना)"].ToString() : string.Empty,
                                    LandRopani = row["१५. जग्गा जमिन (रोपनी)"] != DBNull.Value ? row["१५. जग्गा जमिन (रोपनी)"].ToString() : string.Empty,
                                    ChildrenSchoolType = row["१६.  बालबालिकाको विद्यालयको प्रकार"] != DBNull.Value ? row["१६.  बालबालिकाको विद्यालयको प्रकार"].ToString() : string.Empty,
                                    VehicleId = GetVehicleId(row["१७.१  छ भने के छ ?"] != DBNull.Value ? row["१७.१  छ भने के छ ?"].ToString().Trim() : string.Empty),
                                    IsNaturalDisasterArea = MapBooleanValue(row["१८.घर नजिक प्राकृतिक प्रकोपको खतरा"]?.ToString()),
                                    NaturalDisasterId = GetNaturalDisasterId(row["१८.१ छ भने के छ ?"] != DBNull.Value ? row["१८.१ छ भने के छ ?"].ToString().Trim() : string.Empty),
                                    Earthquake2072Id = GetEarthquake2072Id(row["१९.घर बैशाख १२ गतेको भूकम्पले भत्किएको भए"] != DBNull.Value ? row["१९.घर बैशाख १२ गतेको भूकम्पले भत्किएको भए"].ToString().Trim() : string.Empty),
                                    IsEarthquakeAnudan = MapBooleanValue(row["२०. सरकारबाट आनुदान पाउनु भएको?"]?.ToString()),
                                    EarthquakeKista = row["२०.१. किस्ता पाउनु भएको छ ?"] != DBNull.Value ? row["२०.१. किस्ता पाउनु भएको छ ?"].ToString() : string.Empty,
                                    LocalLevelId = 658,
                                    CreatedBy = row["username"] != DBNull.Value ? row["username"].ToString() : string.Empty,                                    
                                    IsVehicle = MapBooleanValue(row["१७. घरमा यातायातको साधन"]?.ToString()),
                                    ContactNo = row["४. सम्पर्क नम्बर"] != DBNull.Value ? row["४. सम्पर्क नम्बर"].ToString() : string.Empty,
                                    GenderId = GetGenderId(row["३. लिङ्ग"] != DBNull.Value ? row["३. लिङ्ग"].ToString().Trim() : string.Empty),
                                    OldWardNo = row["५.  पुरानो वार्ड नम्बर"] != DBNull.Value ? Convert.ToInt32(row["५.  पुरानो वार्ड नम्बर"]) : 0,
                                    Photo = row["घरमुलीको फोटो"] != DBNull.Value ? row["घरमुलीको फोटो"].ToString() : string.Empty,
                                    GharKoPhoto = "GharkoPhoto.jpg",
                                    MarriedMan = row["५. १ बिबाहित पुरुष"] != DBNull.Value ? Convert.ToInt32(row["५. १ बिबाहित पुरुष"]) : 0,
                                    UnMarriedMan = row["५. २ अबिबाहित पुरुष"] != DBNull.Value ? Convert.ToInt32(row["५. २ अबिबाहित पुरुष"]) : 0,
                                    MarriedWoman = row["५. ३ बिबाहित महिला"] != DBNull.Value ? Convert.ToInt32(row["५. ३ बिबाहित महिला"]) : 0,
                                    UnMarriedWoman = row["५. ४ अबिबाहित महिला"] != DBNull.Value ? Convert.ToInt32(row["५. ४ अबिबाहित महिला"]) : 0,
                                    AnyHasFamilyMemberMoved = MapBooleanValue(row["८.  तपाइको परिवारको सदस्यको बसाइ सराई भएको छ ?"]?.ToString()),
                                    SeniorCitizensTotal = row["६. १  जम्मा संख्या"] != DBNull.Value ? Convert.ToInt32(row["६. १  जम्मा संख्या"]) : 0,
                                    SeniorCitizensMan = row["६. २ पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["६. २ पुरुष संख्या"]) : 0,
                                    SeniorCitizensWoman = row["६. ३ महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["६. ३ महिला संख्या"]) : 0,
                                    SeniorCitizensOthers = row["६. ४ तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["६. ४ तेस्रो लिंगी संख्या"]) : 0,
                                    AnySingleWomen = MapBooleanValue(row["७. तपाइको घरमा एकल महिला हुनुहुन्छ ?"]?.ToString()),
                                    SingleWomenCount = row["७.१ जम्मा संख्या"] != DBNull.Value ? Convert.ToInt32(row["७.१ जम्मा संख्या"]) : 0,
                                    AnyJesthaNagarik = MapBooleanValue(row["६. तपाइको घरमा ज्येष्ठ नागरिक हुनुहुन्छ ?"]?.ToString()),
                                    CreatedDate = (DateOnly?)DateOnly.FromDateTime(DateTime.Now),


                                    IsAnyBusiness = null,//"५८. तपाईको परिवारले कुनै किसिमको व्यापार व्यवसाय, उद्योग गर्नु भएको छ ?"]?.ToString()),
                                    BusinessTypeId = null,
                                    IsLandLalPurja = null, //MapBooleanValue(row["१. जग्गाको लालपुर्जा"]?.ToString()),
                                    IsLandOutOfPalika = null,
                                    LandOwner = null,
                                    AnyDisablePerson = null,
                                    TotalDisablePerson = null,
                                    MaleDisablePerson = null,
                                    FemaleDisablePerson = null,
                                    OtherDisablePerson = null,
                                    CardLinuVayo = null,
                                    KunCardLinuVayo = null,
                                };
                                houseOwnerDetails.Add(houseownerdetail);
                            }
                        }
                        if (houseOwnerDetails.Count > 0)
                        {
                            _context.HouseOwnerDetails.AddRange(houseOwnerDetails);
                            await _context.SaveChangesAsync();
                        }


                        //HouseOwnerDetails Sub Table
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int houseid = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.Id ?? 0;
                            int ward = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? 0;
                            row["HouseOwnerId"] = houseid;

                            //Moved FamilyMemberDetails
                            if (MapBooleanValue(row["८.  तपाइको परिवारको सदस्यको बसाइ सराई भएको छ ?"]?.ToString()) == true)
                            {
                                var movedfamilymemberdetail = new MovedFamilyMemberDetail
                                {
                                    HouseOwnerDetailsId = houseid,
                                    Name = row["८.१ सदस्यको नाम"] != DBNull.Value ? row["८.१ सदस्यको नाम"].ToString() : string.Empty,
                                    Address = row["८.२ बसाई सराई भएको स्थान"] != DBNull.Value ? row["८.२ बसाई सराई भएको स्थान"].ToString() : string.Empty,
                                    TotalMale = row["८.४ पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["८.४ पुरुष संख्या"]) : 0,
                                    TotalFemale = row["८.५  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["८.५  महिला संख्या"]) : 0,
                                    Total = row["८.३ जम्मा संख्या"] != DBNull.Value ? Convert.ToInt32(row["८.३ जम्मा संख्या"]) : 0,
                                    Remarks = row["८.६ कैफियत"] != DBNull.Value ? row["८.६ कैफियत"].ToString() : string.Empty
                                };
                                if (movedfamilymemberdetail.HouseOwnerDetailsId != 0)
                                {
                                    movedFamilyMemberDetails.Add(movedfamilymemberdetail);
                                }
                            }

                            //HouseOwnerCountryGroup
                            if (MapBooleanValue(row["९ परिवारक सदस्य रोजगारीका लागि विदेश गएको छन्"]?.ToString()) == true)
                            {

                                if (row["९.१ भारत"] != DBNull.Value && Convert.ToInt32(row["९.१ भारत"]) > 0)
                                {
                                    var subItem = new HouseOwnerCountryGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        CountryId = 1,
                                        Count = row["९.१ भारत"] != DBNull.Value ? Convert.ToInt32(row["९.१ भारत"]) : 0
                                    };
                                    houseOwnerCountryGroup.Add(subItem);
                                }
                                if (row["९.२ खाडी"] != DBNull.Value && Convert.ToInt32(row["९.२ खाडी"]) > 0)
                                {
                                    var subItem = new HouseOwnerCountryGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        CountryId = 2,
                                        Count = row["९.२ खाडी"] != DBNull.Value ? Convert.ToInt32(row["९.२ खाडी"]) : 0
                                    };
                                    houseOwnerCountryGroup.Add(subItem);
                                }
                                if (row["९. ३ अन्य"] != DBNull.Value && Convert.ToInt32(row["९. ३ अन्य"]) > 0)
                                {
                                    var subItem = new HouseOwnerCountryGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        CountryId = 3,
                                        Count = row["९. ३ अन्य"] != DBNull.Value ? Convert.ToInt32(row["९. ३ अन्य"]) : 0
                                    };
                                    houseOwnerCountryGroup.Add(subItem);
                                }
                            }

                            //HouseOwnerAbdhiGroup
                            if (MapBooleanValue(row["१० परिवारका सदस्य रोजगारीका लागि विदेश गएको गएको अवधि (बर्षमा)"]?.ToString()) == true)
                            {
                                if (row["१०.१ १ बर्ष भन्दा कम"] != DBNull.Value && Convert.ToInt32(row["१०.१ १ बर्ष भन्दा कम"]) > 0)
                                {
                                    var subitem = new HouseOwnerAbdhiGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        AbhadhiId = 1,
                                        Count = row["१०.१ १ बर्ष भन्दा कम"] != DBNull.Value ? Convert.ToInt32(row["१०.१ १ बर्ष भन्दा कम"]) : 0
                                    };
                                    houseOwnerAbdhiGroup.Add(subitem);
                                }
                                if (row["१०.२ २ बर्ष भन्दा कम"] != DBNull.Value && Convert.ToInt32(row["१०.२ २ बर्ष भन्दा कम"]) > 0)
                                {
                                    var subitem = new HouseOwnerAbdhiGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        AbhadhiId = 2,
                                        Count = row["१०.२ २ बर्ष भन्दा कम"] != DBNull.Value ? Convert.ToInt32(row["१०.२ २ बर्ष भन्दा कम"]) : 0
                                    };
                                    houseOwnerAbdhiGroup.Add(subitem);
                                }
                                if (row["१०.३ ३ बर्ष भन्दा कम"] != DBNull.Value && Convert.ToInt32(row["१०.३ ३ बर्ष भन्दा कम"]) > 0)
                                {
                                    var subitem = new HouseOwnerAbdhiGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        AbhadhiId = 3,
                                        Count = row["१०.३ ३ बर्ष भन्दा कम"] != DBNull.Value ? Convert.ToInt32(row["१०.३ ३ बर्ष भन्दा कम"]) : 0
                                    };
                                    houseOwnerAbdhiGroup.Add(subitem);
                                }
                                if (row["१०.४ ४ बर्ष भन्दा कम"] != DBNull.Value && Convert.ToInt32(row["१०.४ ४ बर्ष भन्दा कम"]) > 0)
                                {
                                    var subitem = new HouseOwnerAbdhiGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        AbhadhiId = 4,
                                        Count = row["१०.४ ४ बर्ष भन्दा कम"] != DBNull.Value ? Convert.ToInt32(row["१०.४ ४ बर्ष भन्दा कम"]) : 0
                                    };
                                    houseOwnerAbdhiGroup.Add(subitem);
                                }
                                if (row["१०.५ ५ बर्ष भन्दा कम"] != DBNull.Value && Convert.ToInt32(row["१०.५ ५ बर्ष भन्दा कम"]) > 0)
                                {
                                    var subitem = new HouseOwnerAbdhiGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        AbhadhiId = 5,
                                        Count = row["१०.५ ५ बर्ष भन्दा कम"] != DBNull.Value ? Convert.ToInt32(row["१०.५ ५ बर्ष भन्दा कम"]) : 0
                                    };
                                    houseOwnerAbdhiGroup.Add(subitem);
                                }
                                if (row["१०.६ ६ बर्ष भन्दा बढि"] != DBNull.Value && Convert.ToInt32(row["१०.६ ६ बर्ष भन्दा बढि"]) > 0)
                                {
                                    var subitem = new HouseOwnerAbdhiGroup()
                                    {
                                        HouseOwnerId = houseid,
                                        AbhadhiId = 6,
                                        Count = row["१०.६ ६ बर्ष भन्दा बढि"] != DBNull.Value ? Convert.ToInt32(row["१०.६ ६ बर्ष भन्दा बढि"]) : 0
                                    };
                                    houseOwnerAbdhiGroup.Add(subitem);
                                }
                            }



                        }
                        if (movedFamilyMemberDetails.Count > 0)
                        {
                            _context.MovedFamilyMemberDetails.AddRange(movedFamilyMemberDetails);
                            await _context.SaveChangesAsync();
                        }
                        if (houseOwnerCountryGroup.Count > 0)
                        {
                            _context.HouseOwnerCountryGroups.AddRange(houseOwnerCountryGroup);
                            await _context.SaveChangesAsync();
                        }
                        if (houseOwnerAbdhiGroup.Count > 0)
                        {
                            _context.HouseOwnerAbdhiGroups.AddRange(houseOwnerAbdhiGroup);
                            await _context.SaveChangesAsync();
                        }




                        ////PopulationDetail                        


                        //Dictionary to store the mapping between _index and EducationDetail.Id
                        Dictionary<int, int> indexToPopulationDetailMapId = new Dictionary<int, int>();
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }



                            // Retrieve the _index from sheet1
                            int? index = row["_index"] != DBNull.Value ? (int?)Convert.ToInt32(row["_index"]) : null;

                            var populationdetail = new PopulationDetail
                            {
                                HouseOwnerDetailId = houseid.Value,
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                ReligionId = GetReligionID(row["१. धर्म"] != DBNull.Value ? row["१. धर्म"].ToString().Trim() : string.Empty),
                                IsMarried = MapBooleanValueNotNullable(row["४.विवाहित स्थिति"]?.ToString()),
                                IsBusinessSkill = MapBooleanValueNotNullable(row["३. व्यापार / ब्यबसाय गर्नु भएको छ ?"]?.ToString()),
                                LanguageId = GetLanguageId(row["२.  मातृभाषा"] != DBNull.Value ? row["२.  मातृभाषा"].ToString().Trim() : string.Empty),

                            };
                            _context.PopulationDetails.Add(populationdetail);
                            await _context.SaveChangesAsync();

                            indexToPopulationDetailMapId[index.Value] = populationdetail.Id;
                        }

                        //Population Detail Sub Table
                        foreach (DataRow row in sheet1.Rows)
                        {
                            // Retrieve the _index from sheet1
                            int? index = row["_index"] != DBNull.Value ? (int?)Convert.ToInt32(row["_index"]) : null;
                            if (index == null || !indexToPopulationDetailMapId.ContainsKey(index.Value))
                            {
                                Console.WriteLine($"No matching EducationDetailId found for _index: {index}");
                                continue;
                            }
                            int popid = indexToPopulationDetailMapId[index.Value];


                            if ((row["०-४ बर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["०-४ बर्ष सम्म पुरुष संख्या"]) > 0) || (row["०-४ बर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["०-४ बर्ष सम्म महिला संख्या"]) > 0) || (row["०-४ बर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["०-४ बर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup1 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 1,
                                    Male = row["०-४ बर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["०-४ बर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["०-४ बर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["०-४ बर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["०-४ बर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["०-४ बर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup1);
                            }

                            if ((row["५-९ बर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["५-९ बर्ष सम्म पुरुष संख्या"]) > 0) || (row["५-९ बर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["५-९ बर्ष सम्म महिला संख्या"]) > 0) || (row["५-९ बर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["५-९ बर्ष सम्म महिला संख्या"]) > 0))
                            {
                                var agegroup2 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 2,
                                    Male = row["५-९ बर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["५-९ बर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["५-९ बर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["५-९ बर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["५-९ बर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["५-९ बर्ष सम्म महिला संख्या"]) : 0 //Eroor in excel name i.e heading should be different
                                };
                                populationAgeGroup.Add(agegroup2);
                            }

                            if ((row["१०-१४ बर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["१०-१४ बर्ष सम्म पुरुष संख्या"]) > 0) || (row["१०-१४ बर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["१०-१४ बर्ष सम्म महिला संख्या"]) > 0) || (row["१०-१४ बर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["१०-१४ बर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup3 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 3,
                                    Male = row["१०-१४ बर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["१०-१४ बर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["१०-१४ बर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["१०-१४ बर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["१०-१४ बर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["१०-१४ बर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup3);
                            }

                            if ((row["१५-१९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["१५-१९ वर्ष सम्म पुरुष संख्या"]) > 0) || (row["१५-१९ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["१५-१९ वर्ष सम्म महिला संख्या"]) > 0) || (row["१५-१९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["१५-१९ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup4 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 4,
                                    Male = row["१५-१९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["१५-१९ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["१५-१९ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["१५-१९ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["१५-१९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["१५-१९ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup4);
                            }
                            if ((row["२०-२४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["२०-२४ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["२०-२४ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["२०-२४ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["२०-२४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["२०-२४ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup5 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 5,
                                    Male = row["२०-२४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["२०-२४ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["२०-२४ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["२०-२४ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["२०-२४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["२०-२४ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup5);
                            }

                            if ((row["२५-२९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["२५-२९ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["२५-२९ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["२५-२९ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["२५-२९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["२५-२९ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup6 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 6,
                                    Male = row["२५-२९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["२५-२९ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["२५-२९ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["२५-२९ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["२५-२९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["२५-२९ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup6);
                            }

                            if ((row["३०-३४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["३०-३४ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["३०-३४ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["३०-३४ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["३०-३४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["३०-३४ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup7 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 7,
                                    Male = row["३०-३४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["३०-३४ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["३०-३४ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["३०-३४ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["३०-३४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["३०-३४ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup7);
                            }

                            if ((row["३५-३९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["३५-३९ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["३५-३९ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["३५-३९ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["३५-३९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["३५-३९ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup8 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 8,
                                    Male = row["३५-३९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["३५-३९ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["३५-३९ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["३५-३९ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["३५-३९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["३५-३९ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup8);
                            }

                            if ((row["४०-४४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["४०-४४ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["४०-४४ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["४०-४४ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["४०-४४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["४०-४४ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup9 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 9,
                                    Male = row["४०-४४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["४०-४४ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["४०-४४ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["४०-४४ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["४०-४४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["४०-४४ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup9);
                            }

                            if ((row["४५-४९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["४५-४९ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["४५-४९ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["४५-४९ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["४५-४९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["४५-४९ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup10 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 10,
                                    Male = row["४५-४९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["४५-४९ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["४५-४९ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["४५-४९ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["४५-४९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["४५-४९ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup10);
                            }

                            if ((row["५०-५४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["५०-५४ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["५०-५४ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["५०-५४ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["५०-५४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["५०-५४ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup11 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 11,
                                    Male = row["५०-५४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["५०-५४ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["५०-५४ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["५०-५४ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["५०-५४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["५०-५४ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup11);
                            }

                            if ((row["५५-५९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["५५-५९ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["५५-५९ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["५५-५९ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["५५-५९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["५५-५९ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup12 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 12,
                                    Male = row["५५-५९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["५५-५९ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["५५-५९ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["५५-५९ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["५५-५९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["५५-५९ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup12);
                            }

                            if ((row["६०-६४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["६०-६४ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["६०-६४ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["६०-६४ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["६०-६४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["६०-६४ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup13 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 13,
                                    Male = row["६०-६४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["६०-६४ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["६०-६४ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["६०-६४ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["६०-६४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["६०-६४ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup13);
                            }

                            if ((row["६५-६९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["६५-६९ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["६५-६९ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["६५-६९ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["६५-६९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["६५-६९ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup14 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 14,
                                    Male = row["६५-६९ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["६५-६९ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["६५-६९ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["६५-६९ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["६५-६९ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["६५-६९ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup14);
                            }

                            if ((row["७०-७४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["७०-७४ वर्ष सम्म पुरुष संख्या"]) > 0) ||
                                (row["७०-७४ वर्ष सम्म महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["७०-७४ वर्ष सम्म महिला संख्या"]) > 0) ||
                                (row["७०-७४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["७०-७४ वर्ष सम्म तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup15 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 15,
                                    Male = row["७०-७४ वर्ष सम्म पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["७०-७४ वर्ष सम्म पुरुष संख्या"]) : 0,
                                    Female = row["७०-७४ वर्ष सम्म महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["७०-७४ वर्ष सम्म महिला संख्या"]) : 0,
                                    Other = row["७०-७४ वर्ष सम्म तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["७०-७४ वर्ष सम्म तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup15);
                            }

                            if ((row["७५ वर्ष भन्दा माथिका पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["७५ वर्ष भन्दा माथिका पुरुष संख्या"]) > 0) ||
                                (row["७५ वर्ष भन्दा माथिका महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["७५ वर्ष भन्दा माथिका महिला संख्या"]) > 0) ||
                                (row["७५ वर्ष भन्दा माथिका तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["७५ वर्ष भन्दा माथिका तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var agegroup16 = new PopulationDetailAgeGroup()
                                {
                                    PopulationDetailId = popid,
                                    AgeGroupId = 16,
                                    Male = row["७५ वर्ष भन्दा माथिका पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["७५ वर्ष भन्दा माथिका पुरुष संख्या"]) : 0,
                                    Female = row["७५ वर्ष भन्दा माथिका महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["७५ वर्ष भन्दा माथिका महिला संख्या"]) : 0,
                                    Other = row["७५ वर्ष भन्दा माथिका तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["७५ वर्ष भन्दा माथिका तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationAgeGroup.Add(agegroup16);
                            }


                            if ((row["ब्राह्मण पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["ब्राह्मण पुरुष संख्या"]) > 0) ||
                                 (row["ब्राह्मण महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["ब्राह्मण महिला संख्या"]) > 0) ||
                                 (row["ब्राह्मण तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["ब्राह्मण तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup1 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 1,
                                    Male = row["ब्राह्मण पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["ब्राह्मण पुरुष संख्या"]) : 0,
                                    Female = row["ब्राह्मण महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["ब्राह्मण महिला संख्या"]) : 0,
                                    Other = row["ब्राह्मण तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["ब्राह्मण तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup1);
                            }

                            if ((row["क्षेत्री पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["क्षेत्री पुरुष संख्या"]) > 0) ||
                                (row["क्षेत्री महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["क्षेत्री महिला संख्या"]) > 0) ||
                                (row["क्षेत्री तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["क्षेत्री तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup2 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 2,
                                    Male = row["क्षेत्री पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्षेत्री पुरुष संख्या"]) : 0,
                                    Female = row["क्षेत्री महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्षेत्री महिला संख्या"]) : 0,
                                    Other = row["क्षेत्री तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्षेत्री तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup2);
                            }

                            if ((row["नेवार पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["नेवार पुरुष संख्या"]) > 0) ||
                                (row["नेवार महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["नेवार महिला संख्या"]) > 0) ||
                                (row["नेवार तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["नेवार तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup3 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 3,
                                    Male = row["नेवार पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["नेवार पुरुष संख्या"]) : 0,
                                    Female = row["नेवार महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["नेवार महिला संख्या"]) : 0,
                                    Other = row["नेवार तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["नेवार तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup3);
                            }

                            if ((row["गुरुङ्ग पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["गुरुङ्ग पुरुष संख्या"]) > 0) ||
                                (row["गुरुङ्ग महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["गुरुङ्ग महिला संख्या"]) > 0) ||
                                (row["गुरुङ्ग तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["गुरुङ्ग तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup4 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 4,
                                    Male = row["गुरुङ्ग पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["गुरुङ्ग पुरुष संख्या"]) : 0,
                                    Female = row["गुरुङ्ग महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["गुरुङ्ग महिला संख्या"]) : 0,
                                    Other = row["गुरुङ्ग तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["गुरुङ्ग तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup4);
                            }

                            if ((row["मगर पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["मगर पुरुष संख्या"]) > 0) ||
                                (row["मगर महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["मगर महिला संख्या"]) > 0) ||
                                (row["मगर तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["मगर तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup5 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 5,
                                    Male = row["मगर पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["मगर पुरुष संख्या"]) : 0,
                                    Female = row["मगर महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["मगर महिला संख्या"]) : 0,
                                    Other = row["मगर तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["मगर तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup5);
                            }

                            if ((row["तामाङ्ग पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["तामाङ्ग पुरुष संख्या"]) > 0) ||
                                (row["तामाङ्ग महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["तामाङ्ग महिला संख्या"]) > 0) ||
                                (row["तामाङ्ग तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["तामाङ्ग तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup6 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 6,
                                    Male = row["तामाङ्ग पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["तामाङ्ग पुरुष संख्या"]) : 0,
                                    Female = row["तामाङ्ग महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["तामाङ्ग महिला संख्या"]) : 0,
                                    Other = row["तामाङ्ग तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["तामाङ्ग तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup6);
                            }

                            if ((row["ठकुरी पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["ठकुरी पुरुष संख्या"]) > 0) ||
                                (row["ठकुरी महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["ठकुरी महिला संख्या"]) > 0) ||
                                (row["ठकुरी तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["ठकुरी तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup7 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 7,
                                    Male = row["ठकुरी पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["ठकुरी पुरुष संख्या"]) : 0,
                                    Female = row["ठकुरी महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["ठकुरी महिला संख्या"]) : 0,
                                    Other = row["ठकुरी तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["ठकुरी तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup7);
                            }


                            if ((row["दमाई पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["दमाई पुरुष संख्या"]) > 0) ||
                                (row["दमाई महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["दमाई महिला संख्या"]) > 0) ||
                                (row["दमाई तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["दमाई तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup8 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 8,
                                    Male = row["दमाई पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["दमाई पुरुष संख्या"]) : 0,
                                    Female = row["दमाई महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["दमाई महिला संख्या"]) : 0,
                                    Other = row["दमाई तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["दमाई तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup8);
                            }

                            if ((row["कामि पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["कामि पुरुष संख्या"]) > 0) ||
                                (row["कामि महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["कामि महिला संख्या"]) > 0) ||
                                (row["कामि तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["कामि तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup9 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 9,
                                    Male = row["कामि पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["कामि पुरुष संख्या"]) : 0,
                                    Female = row["कामि महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["कामि महिला संख्या"]) : 0,
                                    Other = row["कामि तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["कामि तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup9);
                            }

                            if ((row["सार्की पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["सार्की पुरुष संख्या"]) > 0) ||
                                (row["सार्की महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["सार्की महिला संख्या"]) > 0) ||
                                (row["सार्की तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["सार्की तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup10 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 10,
                                    Male = row["सार्की पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["सार्की पुरुष संख्या"]) : 0,
                                    Female = row["सार्की महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["सार्की महिला संख्या"]) : 0,
                                    Other = row["सार्की तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["सार्की तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup10);
                            }

                            if ((row["वि.क. / सुनार पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["वि.क. / सुनार पुरुष संख्या"]) > 0) ||
                                (row["वि.क. / सुनार महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["वि.क. / सुनार महिला संख्या"]) > 0) ||
                                (row["वि.क. / सुनार"] != DBNull.Value && Convert.ToInt32(row["वि.क. / सुनार"]) > 0))
                            {
                                var castegroup11 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 11,
                                    Male = row["वि.क. / सुनार पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["वि.क. / सुनार पुरुष संख्या"]) : 0,
                                    Female = row["वि.क. / सुनार महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["वि.क. / सुनार महिला संख्या"]) : 0,
                                    Other = row["वि.क. / सुनार"] != DBNull.Value ? Convert.ToInt32(row["वि.क. / सुनार"]) : 0
                                };
                                populationCasteGroup.Add(castegroup11);
                            }

                            if ((row["योगी/ गिरि / सन्यासी / भारती/वन पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["योगी/ गिरि / सन्यासी / भारती/वन पुरुष संख्या"]) > 0) ||
                                (row["योगी/ गिरि / सन्यासी / भारती/वन महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["योगी/ गिरि / सन्यासी / भारती/वन महिला संख्या"]) > 0) ||
                                (row["योगी/ गिरि / सन्यासी / भारती/वन"] != DBNull.Value && Convert.ToInt32(row["योगी/ गिरि / सन्यासी / भारती/वन"]) > 0))
                            {
                                var castegroup13 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 13,
                                    Male = row["योगी/ गिरि / सन्यासी / भारती/वन पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["योगी/ गिरि / सन्यासी / भारती/वन पुरुष संख्या"]) : 0,
                                    Female = row["योगी/ गिरि / सन्यासी / भारती/वन महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["योगी/ गिरि / सन्यासी / भारती/वन महिला संख्या"]) : 0,
                                    Other = row["योगी/ गिरि / सन्यासी / भारती/वन"] != DBNull.Value ? Convert.ToInt32(row["योगी/ गिरि / सन्यासी / भारती/वन"]) : 0
                                };
                                populationCasteGroup.Add(castegroup13);
                            }

                            if ((row["यादव पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["यादव पुरुष संख्या"]) > 0) ||
                                (row["यादव महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["यादव महिला संख्या"]) > 0) ||
                                (row["यादव तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["यादव तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup15 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 15,
                                    Male = row["यादव पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["यादव पुरुष संख्या"]) : 0,
                                    Female = row["यादव महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["यादव महिला संख्या"]) : 0,
                                    Other = row["यादव तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["यादव तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup15);
                            }

                            if ((row["चौधरी पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["चौधरी पुरुष संख्या"]) > 0) ||
                                (row["चौधरी महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["चौधरी महिला संख्या"]) > 0) ||
                                (row["चौधरी तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["चौधरी तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup17 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 17,
                                    Male = row["चौधरी पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["चौधरी पुरुष संख्या"]) : 0,
                                    Female = row["चौधरी महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["चौधरी महिला संख्या"]) : 0,
                                    Other = row["चौधरी तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["चौधरी तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup17);
                            }


                            if ((row["दनुवार पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["दनुवार पुरुष संख्या"]) > 0) ||
                                (row["दनुवार महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["दनुवार महिला संख्या"]) > 0) ||
                                (row["दनुवार तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["दनुवार तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup18 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 18,
                                    Male = row["दनुवार पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["दनुवार पुरुष संख्या"]) : 0,
                                    Female = row["दनुवार महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["दनुवार महिला संख्या"]) : 0,
                                    Other = row["दनुवार तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["दनुवार तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup18);
                            }

                            if ((row["अन्य पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य पुरुष संख्या"]) > 0) ||
                                (row["अन्य महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य महिला संख्या"]) > 0) ||
                                (row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup19 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 19,
                                    Male = row["अन्य पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य पुरुष संख्या"]) : 0,
                                    Female = row["अन्य महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य महिला संख्या"]) : 0,
                                    Other = row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup19);
                            }

                            if ((row["राई पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["राई पुरुष संख्या"]) > 0) ||
                                (row["राई महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["राई महिला संख्या"]) > 0) ||
                                (row["राई तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["राई तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup20 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 20,
                                    Male = row["राई पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["राई पुरुष संख्या"]) : 0,
                                    Female = row["राई महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["राई महिला संख्या"]) : 0,
                                    Other = row["राई तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["राई तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup20);
                            }

                            if ((row["लिम्बु  पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["लिम्बु  पुरुष संख्या"]) > 0) ||
                                (row["लिम्बु महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["लिम्बु महिला संख्या"]) > 0) ||
                                (row["लिम्बु  तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["लिम्बु  तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup21 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 21,
                                    Male = row["लिम्बु  पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["लिम्बु  पुरुष संख्या"]) : 0,
                                    Female = row["लिम्बु महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["लिम्बु महिला संख्या"]) : 0,
                                    Other = row["लिम्बु  तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["लिम्बु  तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup21);
                            }

                            if ((row["शेर्पा  पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["शेर्पा  पुरुष संख्या"]) > 0) ||
                                (row["शेर्पा  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["शेर्पा  महिला संख्या"]) > 0) ||
                                (row["शेर्तेपा स्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["शेर्तेपा स्रो लिंगी संख्या"]) > 0))
                            {
                                var castegroup22 = new PopulationDetailCasteGroup()
                                {
                                    PopulationId = popid,
                                    CasteId = 22,
                                    Male = row["शेर्पा  पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["शेर्पा  पुरुष संख्या"]) : 0,
                                    Female = row["शेर्पा  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["शेर्पा  महिला संख्या"]) : 0,
                                    Other = row["शेर्तेपा स्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["शेर्तेपा स्रो लिंगी संख्या"]) : 0
                                };
                                populationCasteGroup.Add(castegroup22);
                            }

                            //Musalman,majhi and tharu not implemented cause not found in excel




                            //For Occupation groups

                            if ((row["कृषि तथा पशुपालन पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["कृषि तथा पशुपालन पुरुष संख्या"]) > 0) ||
                                (row["कृषि तथा पशुपालन  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["कृषि तथा पशुपालन  महिला संख्या"]) > 0) ||
                                (row["कृषि तथा पशुपालन तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["कृषि तथा पशुपालन तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup1 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 1,
                                    Male = row["कृषि तथा पशुपालन पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["कृषि तथा पशुपालन पुरुष संख्या"]) : 0,
                                    Female = row["कृषि तथा पशुपालन  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["कृषि तथा पशुपालन  महिला संख्या"]) : 0,
                                    Other = row["कृषि तथा पशुपालन तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["कृषि तथा पशुपालन तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup1);
                            }

                            if ((row["व्यापार पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["व्यापार पुरुष संख्या"]) > 0) ||
                                (row["व्यापार  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["व्यापार  महिला संख्या"]) > 0) ||
                                (row["व्यापार तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["व्यापार तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup2 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 2,
                                    Male = row["व्यापार पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["व्यापार पुरुष संख्या"]) : 0,
                                    Female = row["व्यापार  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["व्यापार  महिला संख्या"]) : 0,
                                    Other = row["व्यापार तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["व्यापार तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup2);
                            }

                            if ((row["सरकारी नोकरीपुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["सरकारी नोकरीपुरुष संख्या"]) > 0) ||
                                (row["सरकारी नोकरी  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["सरकारी नोकरी  महिला संख्या"]) > 0) ||
                                (row["सरकारी नोकरी तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["सरकारी नोकरी तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup3 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 3,
                                    Male = row["सरकारी नोकरीपुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["सरकारी नोकरीपुरुष संख्या"]) : 0,
                                    Female = row["सरकारी नोकरी  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["सरकारी नोकरी  महिला संख्या"]) : 0,
                                    Other = row["सरकारी नोकरी तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["सरकारी नोकरी तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup3);
                            }

                            if ((row["जागिर – अन्य पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["जागिर – अन्य पुरुष संख्या"]) > 0) ||
                                (row["जागिर – अन्य  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["जागिर – अन्य  महिला संख्या"]) > 0) ||
                                (row["जागिर – अन्य तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["जागिर – अन्य तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup4 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 4,
                                    Male = row["जागिर – अन्य पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["जागिर – अन्य पुरुष संख्या"]) : 0,
                                    Female = row["जागिर – अन्य  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["जागिर – अन्य  महिला संख्या"]) : 0,
                                    Other = row["जागिर – अन्य तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["जागिर – अन्य तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup4);
                            }

                            if ((row["ज्याला मजदुर पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["ज्याला मजदुर पुरुष संख्या"]) > 0) ||
                                (row["ज्याला मजदुर  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["ज्याला मजदुर  महिला संख्या"]) > 0) ||
                                (row["ज्याला मजदुर तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["ज्याला मजदुर तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup5 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 5,
                                    Male = row["ज्याला मजदुर पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["ज्याला मजदुर पुरुष संख्या"]) : 0,
                                    Female = row["ज्याला मजदुर  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["ज्याला मजदुर  महिला संख्या"]) : 0,
                                    Other = row["ज्याला मजदुर तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["ज्याला मजदुर तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup5);
                            }

                            if ((row["उद्योग पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["उद्योग पुरुष संख्या"]) > 0) ||
                                (row["उद्योग  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["उद्योग  महिला संख्या"]) > 0) ||
                                (row["उद्योग तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["उद्योग तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup6 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 6,
                                    Male = row["उद्योग पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["उद्योग पुरुष संख्या"]) : 0,
                                    Female = row["उद्योग  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["उद्योग  महिला संख्या"]) : 0,
                                    Other = row["उद्योग तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["उद्योग तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup6);
                            }

                            if ((row["वैदेशिक रोजगार पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["वैदेशिक रोजगार पुरुष संख्या"]) > 0) ||
                                (row["वैदेशिक रोजगार  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["वैदेशिक रोजगार  महिला संख्या"]) > 0) ||
                                (row["वैदेशिक रोजगार तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["वैदेशिक रोजगार तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup7 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 7,
                                    Male = row["वैदेशिक रोजगार पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["वैदेशिक रोजगार पुरुष संख्या"]) : 0,
                                    Female = row["वैदेशिक रोजगार  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["वैदेशिक रोजगार  महिला संख्या"]) : 0,
                                    Other = row["वैदेशिक रोजगार तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["वैदेशिक रोजगार तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup7);
                            }

                            if ((row["अन्य पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य पुरुष संख्या"]) > 0) ||
                                (row["अन्य महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य महिला संख्या"]) > 0) ||
                                (row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var occupationGroup8 = new PopulationDetailOccupationGroup()
                                {
                                    PopulationDetailId = popid,
                                    OccupationDetailId = 8,
                                    Male = row["अन्य पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य पुरुष संख्या"]) : 0,
                                    Female = row["अन्य महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य महिला संख्या"]) : 0,
                                    Other = row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) : 0
                                };
                                populationOccupationGroup.Add(occupationGroup8);
                            }



                        }
                        if (populationAgeGroup.Count > 0)
                        {
                            _context.PopulationDetailAgeGroups.AddRange(populationAgeGroup);
                            await _context.SaveChangesAsync();
                        }
                        if (populationCasteGroup.Count > 0)
                        {
                            _context.PopulationDetailCasteGroups.AddRange(populationCasteGroup);
                            await _context.SaveChangesAsync();
                        }
                        if (populationOccupationGroup.Count > 0)
                        {
                            _context.PopulationDetailOccupationGroups.AddRange(populationOccupationGroup);
                            await _context.SaveChangesAsync();
                        }



                        ////Economic Details
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int male = row["५. १  जम्मा पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["५. १  जम्मा पुरुष संख्या"]) : 0;
                            int female = row["५. २ जम्मा महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["५. २ जम्मा महिला संख्या"]) : 0;
                            int other = row["५. ३ जम्मा तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["५. ३ जम्मा तेस्रो लिंगी संख्या"]) : 0;
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }
                            var economicdetail = new EconomicDetail()
                            {
                                HouseOwnerDetailId = houseid.Value,
                                IsHouseRanted = MapBooleanValueNotNullable(row["IsHouseRented"]?.ToString()),
                                IsAnyDebt = MapBooleanValueNotNullable(row["२. ॠण लिएको"]?.ToString()),
                                AverageMonthlyIncomeId = GetMonthlyIncomeID(row["३.औसत मासिक पारिवारिक आम्दानी (हजारमा)"] != DBNull.Value ? row["३.औसत मासिक पारिवारिक आम्दानी (हजारमा)"].ToString().Trim() : string.Empty),
                                FoodConditionId = GetFoodConditionId(row["४.खाधानन् पर्याप्तताको अवस्था"] != DBNull.Value ? row["४.खाधानन् पर्याप्तताको अवस्था"].ToString().Trim() : string.Empty),
                                TechnicalSkillId = 0,
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                MukhyaPeshaKho = row["५. तपाइको परिवारको मुख्य पेशा कुन हो"] != DBNull.Value ? row["५. तपाइको परिवारको मुख्य पेशा कुन हो"].ToString().Trim() : string.Empty,
                                Male = male,
                                Female = female,
                                Other = other,
                                //self made formula
                                KatiJanaSanglagna = male + female + other
                            };
                            economicDetails.Add(economicdetail);
                        }
                        if (economicDetails.Count > 0)
                        {
                            _context.EconomicDetails.AddRange(economicDetails);
                            await _context.SaveChangesAsync();
                        }

                        ////Economic details SubTable
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int economicid = economicDetails.FirstOrDefault(x => x.MukhyaPeshaKho == row["५. तपाइको परिवारको मुख्य पेशा कुन हो"]?.ToString())?.Id ?? 0;

                            if ((row["कृषि पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["कृषि पुरुष संख्या"]) > 0) || (row["कृषि  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["कृषि  महिला संख्या"]) > 0) || (row["कृषि  तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["कृषि  तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 1,
                                    Male = row["कृषि पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["कृषि पुरुष संख्या"]) : 0,
                                    Female = row["कृषि  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["कृषि  महिला संख्या"]) : 0,
                                    Other = row["कृषि  तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["कृषि  तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }
                            if ((row["पशु जेटीए /जेटी/ग्रापास्वका पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["पशु जेटीए /जेटी/ग्रापास्वका पुरुष संख्या"]) > 0) || (row["पशु जेटीए /जेटी/ग्रापास्वका महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["पशु जेटीए /जेटी/ग्रापास्वका महिला संख्या"]) > 0) || (row["पशु जेटीए /जेटी/ग्रापास्वका तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["पशु जेटीए /जेटी/ग्रापास्वका तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 2,
                                    Male = row["पशु जेटीए /जेटी/ग्रापास्वका पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["पशु जेटीए /जेटी/ग्रापास्वका पुरुष संख्या"]) : 0,
                                    Female = row["पशु जेटीए /जेटी/ग्रापास्वका महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["पशु जेटीए /जेटी/ग्रापास्वका महिला संख्या"]) : 0,
                                    Other = row["पशु जेटीए /जेटी/ग्रापास्वका तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["पशु जेटीए /जेटी/ग्रापास्वका तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }
                            if ((row["विद्युत जडान पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["विद्युत जडान पुरुष संख्या"]) > 0) || (row["विद्युत जडान महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["विद्युत जडान महिला संख्या"]) > 0) || (row["विद्युत जडान तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["विद्युत जडान तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 3,
                                    Male = row["विद्युत जडान पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["विद्युत जडान पुरुष संख्या"]) : 0,
                                    Female = row["विद्युत जडान महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["विद्युत जडान महिला संख्या"]) : 0,
                                    Other = row["विद्युत जडान तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["विद्युत जडान तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }
                            if ((row["मेकानिक्स पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["मेकानिक्स पुरुष संख्या"]) > 0) || (row["मेकानिक्स महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["मेकानिक्स महिला संख्या"]) > 0) || (row["मेकानिक्स तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["मेकानिक्स तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 4,
                                    Male = row["मेकानिक्स पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["मेकानिक्स पुरुष संख्या"]) : 0,
                                    Female = row["मेकानिक्स महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["मेकानिक्स महिला संख्या"]) : 0,
                                    Other = row["मेकानिक्स तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["मेकानिक्स तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }
                            if ((row["सिलाई बुनाई  पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["सिलाई बुनाई  पुरुष संख्या"]) > 0) || (row["सिलाई बुनाई  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["सिलाई बुनाई  महिला संख्या"]) > 0) || (row["सिलाई बुनाई  तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["सिलाई बुनाई  तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 5,
                                    Male = row["सिलाई बुनाई  पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["सिलाई बुनाई  पुरुष संख्या"]) : 0,
                                    Female = row["सिलाई बुनाई  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["सिलाई बुनाई  महिला संख्या"]) : 0,
                                    Other = row["सिलाई बुनाई  तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["सिलाई बुनाई  तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }
                            if ((row["इन्जिनियरिङ पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["इन्जिनियरिङ पुरुष संख्या"]) > 0) || (row["इन्जिनियरिङ महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["इन्जिनियरिङ महिला संख्या"]) > 0) || (row["इन्जिनियरिङ तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["इन्जिनियरिङ तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 6,
                                    Male = row["इन्जिनियरिङ पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["इन्जिनियरिङ पुरुष संख्या"]) : 0,
                                    Female = row["इन्जिनियरिङ महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["इन्जिनियरिङ महिला संख्या"]) : 0,
                                    Other = row["इन्जिनियरिङ तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["इन्जिनियरिङ तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }
                            if ((row["कम्प्यूटर सीप पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["कम्प्यूटर सीप पुरुष संख्या"]) > 0) || (row["कम्प्यूटर सीप महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["कम्प्यूटर सीप महिला संख्या"]) > 0) || (row["कम्प्यूटर सीप तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["कम्प्यूटर सीप तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 7,
                                    Male = row["कम्प्यूटर सीप पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["कम्प्यूटर सीप पुरुष संख्या"]) : 0,
                                    Female = row["कम्प्यूटर सीप महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["कम्प्यूटर सीप महिला संख्या"]) : 0,
                                    Other = row["कम्प्यूटर सीप तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["कम्प्यूटर सीप तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }
                            if ((row["अन्य पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य पुरुष संख्या"]) > 0) || (row["अन्य महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य महिला संख्या"]) > 0) || (row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var technical1 = new EconomicDetailTechnicalSkillGroup()
                                {
                                    EconomicDetailId = economicid,
                                    TechnicalSkillId = 8,
                                    Male = row["अन्य पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य पुरुष संख्या"]) : 0,
                                    Female = row["अन्य महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य महिला संख्या"]) : 0,
                                    Other = row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) : 0,
                                };
                                economicDetailTechnicalSkillGroups.Add(technical1);
                            }

                        }
                        if (economicDetailTechnicalSkillGroups.Count > 0)
                        {
                            _context.EconomicDetailTechnicalSkillGroups.AddRange(economicDetailTechnicalSkillGroups);
                            await _context.SaveChangesAsync();
                        }


                        ////Agriculture Detail


                        Dictionary<int, int> indexToAgricultureDetailMapId = new Dictionary<int, int>();

                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }

                            // Retrieve the _index from sheet1
                            int? index = row["_index"] != DBNull.Value ? (int?)Convert.ToInt32(row["_index"]) : null;


                            var agriculturedetail = new AgricultureDetail()
                            {
                                HouseOwnerDetailId = houseid.Value,
                                IsAnyAnimal = MapBooleanValueNotNullable(row["२. पशु/पन्छी पाल्नु भएको"]?.ToString()),
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                IsLandLalPurja = MapBooleanValueNotNullable(row["१. जग्गाको लालपुर्जा"]?.ToString()),
                                AgricultureLand = MapBooleanValue(row["३. खेति योग्य जमिन छ?"]?.ToString()),
                                AgricultureLandDetail = row["३.१ कति छ ?"] != DBNull.Value ? row["३.१ कति छ ?"].ToString().Trim() : string.Empty,
                                KrishiTathaPasupalanLand = MapBooleanValue(row["४.कृषि तथा पशुपालनको लागि जग्गा प्रयोग गर्नु भएको छ?"]?.ToString()),
                                PokhariMachapalan = MapBooleanValue(row["५. माछा पालन गर्नु भएको छ ?"]?.ToString()),
                                SichaiSubidha = MapBooleanValue(row["६.   सिचाई सुबिधाको उपलब्ध छ?"]?.ToString()),
                                AgricultureProduct = MapBooleanValue(row["७. कृषि उत्पादन गर्नहुन्छ?"]?.ToString()),
                                AnimalProduct = MapBooleanValue(row["८.  पशुपालन गर्नुहुन्छ ?"]?.ToString()),
                                ModernAgriculture = MapBooleanValue(row["९. व्यावसायिक तथा आधुनिक कृषि फर्म छ?"]?.ToString()),
                                ModernAgricultureType = row["९.१ कुन फर्म छ?"] != DBNull.Value ? row["९.१ कुन फर्म छ?"].ToString().Trim() : null,
                                ModernAgricultureName = row["१०.फर्म नगदेबाली को प्रकार ?"] != DBNull.Value ? row["१०.फर्म नगदेबाली को प्रकार ?"].ToString().Trim() : null,
                                CollectionCentre = MapBooleanValue(row["११. कृषि संकलन केन्द्र को व्यवस्था छ?"]?.ToString()),
                                CoolingCenter = MapBooleanValue(row["१२.  दुग्ध  चिस्यान केन्द्रको व्यवस्था छ ?"]?.ToString())
                            };
                            _context.AgricultureDetails.Add(agriculturedetail);
                            await _context.SaveChangesAsync();
                            indexToAgricultureDetailMapId[index.Value] = agriculturedetail.Id;
                        }




                        //Agriculturedetail SubTable
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? index = row["_index"] != DBNull.Value ? (int?)Convert.ToInt32(row["_index"]) : null;
                            if (index == null || !indexToAgricultureDetailMapId.ContainsKey(index.Value))
                            {
                                Console.WriteLine($"No matching Agricultureid found for _index: {index}");
                                continue;
                            }
                            int agriId = indexToAgricultureDetailMapId[index.Value];
                            if (row["२.१ बाख्रा/भेडा/च्यांग्रा"] != DBNull.Value && Convert.ToInt32(row["२.१ बाख्रा/भेडा/च्यांग्रा"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 1,
                                    Total = Convert.ToInt32(row["२.१ बाख्रा/भेडा/च्यांग्रा"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.२ कुखुरा"] != DBNull.Value && Convert.ToInt32(row["२.२ कुखुरा"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 2,
                                    Total = Convert.ToInt32(row["२.२ कुखुरा"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.३ गाइ"] != DBNull.Value && Convert.ToInt32(row["२.३ गाइ"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 3,
                                    Total = Convert.ToInt32(row["२.३ गाइ"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.४ सुँगुर/बंगुर"] != DBNull.Value && Convert.ToInt32(row["२.४ सुँगुर/बंगुर"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 4,
                                    Total = Convert.ToInt32(row["२.४ सुँगुर/बंगुर"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.५ हास/परेवा"] != DBNull.Value && Convert.ToInt32(row["२.५ हास/परेवा"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 5,
                                    Total = Convert.ToInt32(row["२.५ हास/परेवा"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.६ खरायो"] != DBNull.Value && Convert.ToInt32(row["२.६ खरायो"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 6,
                                    Total = Convert.ToInt32(row["२.६ खरायो"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.७ घोडा/खच्हर"] != DBNull.Value && Convert.ToInt32(row["२.७ घोडा/खच्हर"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 7,
                                    Total = Convert.ToInt32(row["२.७ घोडा/खच्हर"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.८ भैसी"] != DBNull.Value && Convert.ToInt32(row["२.८ भैसी"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 8,
                                    Total = Convert.ToInt32(row["२.८ भैसी"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.९ गोरु"] != DBNull.Value && Convert.ToInt32(row["२.९ गोरु"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 9,
                                    Total = Convert.ToInt32(row["२.९ गोरु"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.१० रागो"] != DBNull.Value && Convert.ToInt32(row["२.१० रागो"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 10,
                                    Total = Convert.ToInt32(row["२.१० रागो"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.११ याक/चौरी"] != DBNull.Value && Convert.ToInt32(row["२.११ याक/चौरी"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 11,
                                    Total = Convert.ToInt32(row["२.११ याक/चौरी"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }
                            if (row["२.१२अन्य"] != DBNull.Value && Convert.ToInt32(row["२.१२अन्य"]) > 0)
                            {
                                var animal = new AgricultureDetailAnimalGroup()
                                {
                                    AgricultureDetailId = agriId,
                                    AnimalId = 12,
                                    Total = Convert.ToInt32(row["२.१२अन्य"])
                                };
                                agricultureDetailAnimals.Add(animal);
                            }



                            //Product Detail Table
                            if (row["_7_1_Dhan_kg_ma"] != DBNull.Value && Convert.ToInt32(row["_7_1_Dhan_kg_ma"]) > 0)
                            {
                                var product = new AgricultureProductDetail()
                                {
                                    AgricultureDetailId = agriId,
                                    BaliKoName = "धान",
                                    Pariman = row["_7_1_Dhan_kg_ma"].ToString().Trim()
                                };
                                agricultureProductDetails.Add(product);
                            }
                            if (row["_7_2_Makai_kg_ma"] != DBNull.Value && Convert.ToInt32(row["_7_2_Makai_kg_ma"]) > 0)
                            {
                                var product = new AgricultureProductDetail()
                                {
                                    AgricultureDetailId = agriId,
                                    BaliKoName = "मकई",
                                    Pariman = row["_7_2_Makai_kg_ma"].ToString().Trim()
                                };
                                agricultureProductDetails.Add(product);
                            }
                            if (row["_7_2_Kodo_kg_ma"] != DBNull.Value && Convert.ToInt32(row["_7_2_Kodo_kg_ma"]) > 0)
                            {
                                var product = new AgricultureProductDetail()
                                {
                                    AgricultureDetailId = agriId,
                                    BaliKoName = "कोडो",
                                    Pariman = row["_7_2_Kodo_kg_ma"].ToString().Trim()
                                };
                                agricultureProductDetails.Add(product);
                            }
                            if (row["_7_2_Phapar_kg_ma"] != DBNull.Value && Convert.ToInt32(row["_7_2_Phapar_kg_ma"]) > 0)
                            {
                                var product = new AgricultureProductDetail()
                                {
                                    AgricultureDetailId = agriId,
                                    BaliKoName = "फाफर",
                                    Pariman = row["_7_2_Phapar_kg_ma"].ToString().Trim()
                                };
                                agricultureProductDetails.Add(product);
                            }
                            if (row["_7_2_Others_kg_ma"] != DBNull.Value && Convert.ToInt32(row["_7_2_Others_kg_ma"]) > 0)
                            {
                                var product = new AgricultureProductDetail()
                                {
                                    AgricultureDetailId = agriId,
                                    BaliKoName = "अन्य",
                                    Pariman = row["_7_2_Others_kg_ma"].ToString().Trim()
                                };
                                agricultureProductDetails.Add(product);
                            }
                        }
                        if (agricultureDetailAnimals.Count > 0)
                        {
                            _context.AgricultureDetailAnimalGroups.AddRange(agricultureDetailAnimals);
                            await _context.SaveChangesAsync();
                        }
                        if (agricultureProductDetails.Count > 0)
                        {
                            _context.AgricultureProductDetails.AddRange(agricultureProductDetails);
                            await _context.SaveChangesAsync();
                        }




                        ////Health Details
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }
                            var healthdetail = new HealthDetail()
                            {
                                HouseOwnerDetailId = houseid.Value,
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                IsChronicDiseases = MapBooleanValueNotNullable(row["१. परिवारको सदस्यलाई कुनै दिर्घ रोग लागेको"]?.ToString()),
                                IsDisabilityFamily = MapBooleanValueNotNullable(row["३. परिवारमा कुनै व्यक्ति अपांग हुनुहुन्छ?"]?.ToString()),
                                UpacharWhere = row["२.उपचार गर्न कहाँ जानुहुन्छ?"] != DBNull.Value ? row["२.उपचार गर्न कहाँ जानुहुन्छ?"].ToString().Trim() : string.Empty,
                                SchoolC23 = null,
                            };
                            healthDetails.Add(healthdetail);
                        }
                        if (healthDetails.Count > 0)
                        {
                            _context.HealthDetails.AddRange(healthDetails);
                            await _context.SaveChangesAsync();
                        }


                        //HealthDetails Sub Tables
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int healthId = healthDetails.FirstOrDefault(x => x.UpacharWhere == row["२.उपचार गर्न कहाँ जानुहुन्छ?"]?.ToString())?.Id ?? 0;
                            if (MapBooleanValueNotNullable(row["१. परिवारको सदस्यलाई कुनै दिर्घ रोग लागेको"]?.ToString()) == true)
                            {
                                if ((row["क्षयरोग पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["क्षयरोग पुरुष संख्या"]) > 0) || (row["क्षयरोग महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["क्षयरोग महिला संख्या"]) > 0) || (row["क्षयरोग तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["क्षयरोग तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var Chronic = new HealthDetailChronicDiseaseGroup()
                                    {
                                        HealthDetailIid = healthId,
                                        ChronicDiseaseId = 1,
                                        Male = row["क्षयरोग पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्षयरोग पुरुष संख्या"]) : 0,
                                        Female = row["क्षयरोग महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्षयरोग महिला संख्या"]) : 0,
                                        Other = row["क्षयरोग तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्षयरोग तेस्रो लिंगी संख्या"]) : 0,
                                    };
                                    healthChronicGroups.Add(Chronic);
                                }
                                if ((row["क्यान्सर पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["क्यान्सर पुरुष संख्या"]) > 0) || (row["क्यान्सर महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["क्यान्सर महिला संख्या"]) > 0) || (row["क्यान्सर"] != DBNull.Value && Convert.ToInt32(row["क्यान्सर"]) > 0))
                                {
                                    var Chronic = new HealthDetailChronicDiseaseGroup()
                                    {
                                        HealthDetailIid = healthId,
                                        ChronicDiseaseId = 2,
                                        Male = row["क्यान्सर पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्यान्सर पुरुष संख्या"]) : 0,
                                        Female = row["क्यान्सर महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["क्यान्सर महिला संख्या"]) : 0,
                                        Other = row["क्यान्सर"] != DBNull.Value ? Convert.ToInt32(row["क्यान्सर"]) : 0,
                                    };
                                    healthChronicGroups.Add(Chronic);
                                }
                                if ((row["एच.आई.भी / एड्स पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["एच.आई.भी / एड्स पुरुष संख्या"]) > 0) || (row["एच.आई.भी / एड्समहिला संख्या"] != DBNull.Value && Convert.ToInt32(row["एच.आई.भी / एड्समहिला संख्या"]) > 0) || (row["एच.आई.भी / एड्स तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["एच.आई.भी / एड्स तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var Chronic = new HealthDetailChronicDiseaseGroup()
                                    {
                                        HealthDetailIid = healthId,
                                        ChronicDiseaseId = 3,
                                        Male = row["एच.आई.भी / एड्स पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["एच.आई.भी / एड्स पुरुष संख्या"]) : 0,
                                        Female = row["एच.आई.भी / एड्समहिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["एच.आई.भी / एड्समहिला संख्या"]) : 0,
                                        Other = row["एच.आई.भी / एड्स तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["एच.आई.भी / एड्स तेस्रो लिंगी संख्या"]) : 0,
                                    };
                                    healthChronicGroups.Add(Chronic);
                                }
                                if ((row["चिनी रोग पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["चिनी रोग पुरुष संख्या"]) > 0) || (row["चिनी रोग महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["चिनी रोग महिला संख्या"]) > 0) || (row["चिनी रोग तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["चिनी रोग तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var Chronic = new HealthDetailChronicDiseaseGroup()
                                    {
                                        HealthDetailIid = healthId,
                                        ChronicDiseaseId = 4,
                                        Male = row["चिनी रोग पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["चिनी रोग पुरुष संख्या"]) : 0,
                                        Female = row["चिनी रोग महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["चिनी रोग महिला संख्या"]) : 0,
                                        Other = row["चिनी रोग तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["चिनी रोग तेस्रो लिंगी संख्या"]) : 0,
                                    };
                                    healthChronicGroups.Add(Chronic);
                                }
                                if ((row["ब्लड प्रेसर पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["ब्लड प्रेसर पुरुष संख्या"]) > 0) || (row["ब्लड प्रेसर महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["ब्लड प्रेसर महिला संख्या"]) > 0) || (row["ब्लड प्रेसर तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["ब्लड प्रेसर तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var Chronic = new HealthDetailChronicDiseaseGroup()
                                    {
                                        HealthDetailIid = healthId,
                                        ChronicDiseaseId = 5,
                                        Male = row["ब्लड प्रेसर पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["ब्लड प्रेसर पुरुष संख्या"]) : 0,
                                        Female = row["ब्लड प्रेसर महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["ब्लड प्रेसर महिला संख्या"]) : 0,
                                        Other = row["ब्लड प्रेसर तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["ब्लड प्रेसर तेस्रो लिंगी संख्या"]) : 0,
                                    };
                                    healthChronicGroups.Add(Chronic);
                                }
                                if ((row["अन्य पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य पुरुष संख्या"]) > 0) || (row["अन्य महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य महिला संख्या"]) > 0) || (row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var Chronic = new HealthDetailChronicDiseaseGroup()
                                    {
                                        HealthDetailIid = healthId,
                                        ChronicDiseaseId = 6,
                                        Male = row["अन्य पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य पुरुष संख्या"]) : 0,
                                        Female = row["अन्य महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य महिला संख्या"]) : 0,
                                        Other = row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) : 0,
                                    };
                                    healthChronicGroups.Add(Chronic);
                                }
                            }
                            if (MapBooleanValueNotNullable(row["३. परिवारमा कुनै व्यक्ति अपांग हुनुहुन्छ?"]?.ToString()) == true)
                            {

                                //HealthDeatilDisabilityType
                                if ((row["शारीरिक अपाङ्ग पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["शारीरिक अपाङ्ग पुरुष संख्या"]) > 0) || (row["शारीरिक अपाङ्ग  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["शारीरिक अपाङ्ग  महिला संख्या"]) > 0) || (row["शारीरिक अपाङ्ग तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["शारीरिक अपाङ्ग तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityType = new HealthDetailDisabilityTypeGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityTypeId = 1,
                                        Male = row["शारीरिक अपाङ्ग पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["शारीरिक अपाङ्ग पुरुष संख्या"]) : 0,
                                        Female = row["शारीरिक अपाङ्ग  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["शारीरिक अपाङ्ग  महिला संख्या"]) : 0,
                                        Other = row["शारीरिक अपाङ्ग तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["शारीरिक अपाङ्ग तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyTypeGroups.Add(disabilityType);
                                }
                                if ((row["दृष्टिविहिन र न्यून दृष्टिविहिन पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["दृष्टिविहिन र न्यून दृष्टिविहिन पुरुष संख्या"]) > 0) || (row["दृष्टिविहिन र न्यून दृष्टिविहिन महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["दृष्टिविहिन र न्यून दृष्टिविहिन महिला संख्या"]) > 0) || (row["दृष्टिविहिन र न्यून दृष्टिविहिन तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["दृष्टिविहिन र न्यून दृष्टिविहिन तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityType = new HealthDetailDisabilityTypeGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityTypeId = 2,
                                        Male = row["दृष्टिविहिन र न्यून दृष्टिविहिन पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["दृष्टिविहिन र न्यून दृष्टिविहिन पुरुष संख्या"]) : 0,
                                        Female = row["दृष्टिविहिन र न्यून दृष्टिविहिन महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["दृष्टिविहिन र न्यून दृष्टिविहिन महिला संख्या"]) : 0,
                                        Other = row["दृष्टिविहिन र न्यून दृष्टिविहिन तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["दृष्टिविहिन र न्यून दृष्टिविहिन तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyTypeGroups.Add(disabilityType);
                                }
                                if ((row["सुस्त मनसिथति / बौद्धिक आपंगा पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["सुस्त मनसिथति / बौद्धिक आपंगा पुरुष संख्या"]) > 0) || (row["सुस्त मनसिथति / बौद्धिक आपंगा महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["सुस्त मनसिथति / बौद्धिक आपंगा महिला संख्या"]) > 0) || (row["सुस्त मनसिथति / बौद्धिक आपंगा तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["सुस्त मनसिथति / बौद्धिक आपंगा तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityType = new HealthDetailDisabilityTypeGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityTypeId = 3,
                                        Male = row["सुस्त मनसिथति / बौद्धिक आपंगा पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["सुस्त मनसिथति / बौद्धिक आपंगा पुरुष संख्या"]) : 0,
                                        Female = row["सुस्त मनसिथति / बौद्धिक आपंगा महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["सुस्त मनसिथति / बौद्धिक आपंगा महिला संख्या"]) : 0,
                                        Other = row["सुस्त मनसिथति / बौद्धिक आपंगा तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["सुस्त मनसिथति / बौद्धिक आपंगा तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyTypeGroups.Add(disabilityType);
                                }
                                if ((row["अटिजम पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["अटिजम पुरुष संख्या"]) > 0) || (row["अटिजम महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["अटिजम महिला संख्या"]) > 0) || (row["अटिजम तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["अटिजम तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityType = new HealthDetailDisabilityTypeGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityTypeId = 4,
                                        Male = row["अटिजम पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["अटिजम पुरुष संख्या"]) : 0,
                                        Female = row["अटिजम महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["अटिजम महिला संख्या"]) : 0,
                                        Other = row["अटिजम तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["अटिजम तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyTypeGroups.Add(disabilityType);
                                }
                                if ((row["अन्य पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य पुरुष संख्या"]) > 0) || (row["अन्य महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य महिला संख्या"]) > 0) || (row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityType = new HealthDetailDisabilityTypeGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityTypeId = 5,
                                        Male = row["अन्य पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य पुरुष संख्या"]) : 0,
                                        Female = row["अन्य महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य महिला संख्या"]) : 0,
                                        Other = row["अन्य तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["अन्य तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyTypeGroups.Add(disabilityType);
                                }


                                //Health Detail Disability Card Group
                                if ((row["रातो कार्डपुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["रातो कार्डपुरुष संख्या"]) > 0) || (row["रातो कार्ड महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["रातो कार्ड महिला संख्या"]) > 0) || (row["रातो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["रातो कार्ड तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityCard = new HealthDetailDisabilityCardGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityCardId = 1,
                                        Male = row["रातो कार्डपुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["रातो कार्डपुरुष संख्या"]) : 0,
                                        Female = row["रातो कार्ड महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["रातो कार्ड महिला संख्या"]) : 0,
                                        Other = row["रातो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["रातो कार्ड तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyCardGroups.Add(disabilityCard);
                                }
                                if ((row["निलो कार्डपुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["निलो कार्डपुरुष संख्या"]) > 0) || (row["निलो कार्ड महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["निलो कार्ड महिला संख्या"]) > 0) || (row["निलो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["निलो कार्ड तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityCard = new HealthDetailDisabilityCardGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityCardId = 2,
                                        Male = row["निलो कार्डपुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["निलो कार्डपुरुष संख्या"]) : 0,
                                        Female = row["निलो कार्ड महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["निलो कार्ड महिला संख्या"]) : 0,
                                        Other = row["निलो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["निलो कार्ड तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyCardGroups.Add(disabilityCard);
                                }
                                if ((row["पहेलो  कार्डपुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["पहेलो  कार्डपुरुष संख्या"]) > 0) || (row["पहेलो कार्ड महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["पहेलो कार्ड महिला संख्या"]) > 0) || (row["पहेलो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["पहेलो कार्ड तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityCard = new HealthDetailDisabilityCardGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityCardId = 3,
                                        Male = row["पहेलो  कार्डपुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["पहेलो  कार्डपुरुष संख्या"]) : 0,
                                        Female = row["पहेलो कार्ड महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["पहेलो कार्ड महिला संख्या"]) : 0,
                                        Other = row["पहेलो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["पहेलो कार्ड तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyCardGroups.Add(disabilityCard);
                                }
                                if ((row["सेतो कार्डपुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["सेतो कार्डपुरुष संख्या"]) > 0) || (row["सेतो कार्ड महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["सेतो कार्ड महिला संख्या"]) > 0) || (row["सेतो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["सेतो कार्ड तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityCard = new HealthDetailDisabilityCardGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityCardId = 4,
                                        Male = row["सेतो कार्डपुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["सेतो कार्डपुरुष संख्या"]) : 0,
                                        Female = row["सेतो कार्ड महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["सेतो कार्ड महिला संख्या"]) : 0,
                                        Other = row["सेतो कार्ड तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["सेतो कार्ड तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabiltyCardGroups.Add(disabilityCard);
                                }



                                //Health Detail Disabilty Reason Table
                                if ((row["जन्मजात पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्मजात पुरुष संख्या"]) > 0) || (row["जन्मजात  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्मजात  महिला संख्या"]) > 0) || (row["जन्मजात तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्मजात तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityReason = new HealthDetailDisabilityReasonGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityReasonId = 1,
                                        Male = row["जन्मजात पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्मजात पुरुष संख्या"]) : 0,
                                        Female = row["जन्मजात  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्मजात  महिला संख्या"]) : 0,
                                        Other = row["जन्मजात तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्मजात तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabilityReasons.Add(disabilityReason);
                                }
                                if ((row["जन्मदको समयमा पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्मदको समयमा पुरुष संख्या"]) > 0) || (row["जन्मदको समयमा महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्मदको समयमा महिला संख्या"]) > 0) || (row["जन्मदको समयमा तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्मदको समयमा तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityReason = new HealthDetailDisabilityReasonGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityReasonId = 2,
                                        Male = row["जन्मदको समयमा पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्मदको समयमा पुरुष संख्या"]) : 0,
                                        Female = row["जन्मदको समयमा महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्मदको समयमा महिला संख्या"]) : 0,
                                        Other = row["जन्मदको समयमा तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्मदको समयमा तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabilityReasons.Add(disabilityReason);
                                }
                                if ((row["जन्म पश्चात (रोगको कारण) पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्म पश्चात (रोगको कारण) पुरुष संख्या"]) > 0) || (row["जन्म पश्चात (रोगको कारण) महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्म पश्चात (रोगको कारण) महिला संख्या"]) > 0) || (row["जन्म पश्चात (रोगको कारण) तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्म पश्चात (रोगको कारण) तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityReason = new HealthDetailDisabilityReasonGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityReasonId = 3,
                                        Male = row["जन्म पश्चात (रोगको कारण) पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्म पश्चात (रोगको कारण) पुरुष संख्या"]) : 0,
                                        Female = row["जन्म पश्चात (रोगको कारण) महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्म पश्चात (रोगको कारण) महिला संख्या"]) : 0,
                                        Other = row["जन्म पश्चात (रोगको कारण) तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्म पश्चात (रोगको कारण) तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabilityReasons.Add(disabilityReason);
                                }
                                if ((row["जन्म पश्चात (दुर्घटनाको कारण) पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्म पश्चात (दुर्घटनाको कारण) पुरुष संख्या"]) > 0) || (row["जन्म पश्चात (दुर्घटनाको कारण) महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्म पश्चात (दुर्घटनाको कारण) महिला संख्या"]) > 0) || (row["जन्म पश्चात (दुर्घटनाको कारण) तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["जन्म पश्चात (दुर्घटनाको कारण) तेस्रो लिंगी संख्या"]) > 0))
                                {
                                    var disabilityReason = new HealthDetailDisabilityReasonGroup()
                                    {
                                        HealthDetailId = healthId,
                                        DisabilityReasonId = 4,
                                        Male = row["जन्म पश्चात (दुर्घटनाको कारण) पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्म पश्चात (दुर्घटनाको कारण) पुरुष संख्या"]) : 0,
                                        Female = row["जन्म पश्चात (दुर्घटनाको कारण) महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्म पश्चात (दुर्घटनाको कारण) महिला संख्या"]) : 0,
                                        Other = row["जन्म पश्चात (दुर्घटनाको कारण) तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["जन्म पश्चात (दुर्घटनाको कारण) तेस्रो लिंगी संख्या"]) : 0
                                    };
                                    healthDisabilityReasons.Add(disabilityReason);
                                }

                            }
                        }
                        if (healthChronicGroups.Count > 0)
                        {
                            _context.HealthDetailChronicDiseaseGroups.AddRange(healthChronicGroups);
                            await _context.SaveChangesAsync();
                        }
                        if (healthDisabiltyTypeGroups.Count > 0)
                        {
                            _context.HealthDetailDisabilityTypeGroups.AddRange(healthDisabiltyTypeGroups);
                            await _context.SaveChangesAsync();
                        }
                        if (healthDisabilityReasons.Count > 0)
                        {
                            _context.HealthDetailDisabilityReasonGroups.AddRange(healthDisabilityReasons);
                            await _context.SaveChangesAsync();
                        }
                        if (healthDisabiltyCardGroups.Count > 0)
                        {
                            _context.HealthDetailDisabilityCardGroups.AddRange(healthDisabiltyCardGroups);
                            await _context.SaveChangesAsync();
                        }





                        ////EducationDetails

                        var sheet4GroupedByParentIndex = sheet4.AsEnumerable()
                                .GroupBy(row => Convert.ToInt32(row["_parent_index"]))
                                .ToDictionary(group => group.Key, group => group.ToList());

                        //// Dictionary to store the mapping between _index and EducationDetail.Id
                        Dictionary<int, int> indexToEducationDetailIdMap = new Dictionary<int, int>();

                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }



                            // Retrieve the _index from sheet1
                            int? index = row["_index"] != DBNull.Value ? (int?)Convert.ToInt32(row["_index"]) : null;
                            //if (index == null)
                            //{
                            //    // Log or handle missing index
                            //    Console.WriteLine($"No index found in sheet1 for house ID: {houseid}");
                            //    continue;  // Skip if no index
                            //}

                            // Check if there are any matching rows in sheet4
                            bool sheet4DataExists = sheet4GroupedByParentIndex.ContainsKey(index.Value);
                            List<DataRow> matchingSheet4Rows = sheet4DataExists ? sheet4GroupedByParentIndex[index.Value] : new List<DataRow>();

                            // Step 3: Set the default value for HaveFeedIronPillsForFemale
                            bool haveFeedIronPillsForFemale = false; // Default value when there's no matching data in sheet4

                            // If there are matching rows in sheet4, use the data from there
                            if (sheet4DataExists)
                            {
                                // You could also handle multiple matching rows here if needed
                                var sheet4Row = matchingSheet4Rows.First();
                                haveFeedIronPillsForFemale = MapBooleanValueNotNullable(sheet4Row["३.१.५ गर्भवती हुँदा कति दिन सम्म आईरन चक्की खानुभयो?"]?.ToString().Trim());
                            }



                            var educationdetail = new EducationDetail()
                            {
                                HouseOwnerDetailId = houseid.Value,
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                AnyChild5To14GoingtoSchool = MapBooleanValue(row["३.       तपाईको घरमा ५-१४ वर्षको विद्यालय नजाने बच्चाहरु छन ?"]?.ToString().Trim()),
                                StayAddress = row["३.१ हाल कहाँ छन"] != DBNull.Value ? row["३.१ हाल कहाँ छन"].ToString().Trim() : null,
                                AnyChild10To19 = MapBooleanValue(row["४.       तपाईको घरमा १०-१९ वर्षको किशोर किशोरीहरु छन ?"]?.ToString().Trim()),
                                Child10To19Male = row["४.१ किशोर  संख्या"] != DBNull.Value ? Convert.ToInt32(row["४.१ किशोर  संख्या"]) : 0,
                                Child10To19Female = row["४.२ किशोरी  संख्या"] != DBNull.Value ? Convert.ToInt32(row["४.२ किशोरी  संख्या"]) : 0,
                                HaveFeedIronPillsForFemale = haveFeedIronPillsForFemale,
                                HaveTenagersFemaleTranningAboutHealth = null,
                                AnyTorturePhysicalAndMental = MapBooleanValue(row["५.    तपाइको घरका वालवालिकालाइ विधालयले शारीरिक तथा मानसिक यातना दिने गरेको छ ?(वालवालिकाहरुलाइ पनि सोध्ने)"]?.ToString().Trim()),
                                AnyChildHaveNotGoToCollage = MapBooleanValue(row["६.      तपाइको घरमा आधारभुत तहमा (कक्षा १-८)शिक्षा पश्चात विधालय नगएका वालवालिका छन ?"]?.ToString().Trim()),
                                WhereAreTheyNow = null,
                                //WhereAreTheyNow = GetWhereAreTheyNow(row["ColumnName"] != DBNull.Value ? row["ColumnName"].ToString().Trim() : string.Empty),
                                AnyVocationalTraning = MapBooleanValue(row["६.२ उनीहरुले सिपमुलक तालिम लिएका छन ?"]?.ToString().Trim()),
                                VocationalTraningName = row["६.२.१ सिपमुलक तालिमको नाम"] != DBNull.Value ? row["६.२.१ सिपमुलक तालिमको नाम"].ToString().Trim() : null,
                                AnyViolenceOccurredYourChild = row["७.       तपाइको घरका वालवालिकाहरु विरुद्ध घरपरिवार,समुदायमा वा सार्वजनिक स्थलमा देहायको मध्ये कुनै हिंसा भएको छ ? वालवालिकाहरुलाइ सोध्ने)"] != DBNull.Value ? row["७.       तपाइको घरका वालवालिकाहरु विरुद्ध घरपरिवार,समुदायमा वा सार्वजनिक स्थलमा देहायको मध्ये कुनै हिंसा भएको छ ? वालवालिकाहरुलाइ सोध्ने)"].ToString().Trim() : null,
                                RegisterCaseAddress = row["७.१ उजुरि दिन कहा जानुभयो ?"] != DBNull.Value ? row["७.१ उजुरि दिन कहा जानुभयो ?"].ToString().Trim() : null,
                                AnyKamalariFemale = MapBooleanValue(row["८.        तपाईको परिवारको कुनै महिलालाई कमलरी राख्नु भएको छ ?"]?.ToString().Trim())
                            };
                            //educationDetails.Add(educationdetail);



                            _context.EducationDetails.Add(educationdetail);
                            await _context.SaveChangesAsync();

                            indexToEducationDetailIdMap[index.Value] = educationdetail.Id;
                        }


                        //EducationDetail Sub Tables
                        foreach (DataRow row in sheet1.Rows)
                        {
                            // Retrieve the _index from sheet1
                            int? index = row["_index"] != DBNull.Value ? (int?)Convert.ToInt32(row["_index"]) : null;
                            if (index == null || !indexToEducationDetailIdMap.ContainsKey(index.Value))
                            {
                                Console.WriteLine($"No matching EducationDetailId found for _index: {index}");
                                continue;
                            }

                            // Retrieve the corresponding EducationDetailId using the _index
                            int educationDetailId = indexToEducationDetailIdMap[index.Value];



                            //for schoolLayerId=1
                            var eduSchool = new EducationDetailSchoolGroup()
                            {
                                EducationId = educationDetailId,
                                SchoolLayerId = 1,
                                SchoolTimeId = GetSchoolTimeId(row["१.विद्यालय जान लाग्ने समय आधारभूततह आधारमा"]?.ToString().Trim()),
                            };
                            educationDetailSchoolGroups.Add(eduSchool);

                            //ForSchoolLayerID=2
                            var eduSchool2 = new EducationDetailSchoolGroup()
                            {
                                EducationId = educationDetailId,
                                SchoolLayerId = 2,
                                SchoolTimeId = GetSchoolTimeId(row["२      विद्यालय जान लाग्ने समय मा.वि. तह आधारमा"]?.ToString().Trim())
                            };
                            educationDetailSchoolGroups.Add(eduSchool2);






                            //ForEducationEducationalLevelGroup

                            if ((row["पढन नसक्ने पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["पढन नसक्ने पुरुष संख्या"]) > 0) ||
                                (row["पढन नसक्ने महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["पढन नसक्ने महिला संख्या"]) > 0) ||
                                (row["पढन नसक्नेतेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["पढन नसक्नेतेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level1 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 1,
                                    Male = row["पढन नसक्ने पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["पढन नसक्ने पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["पढन नसक्ने महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["पढन नसक्ने महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["पढन नसक्नेतेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["पढन नसक्नेतेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level1);
                            }

                            if ((row["लेख्न नसक्ने पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["लेख्न नसक्ने पुरुष संख्या"]) > 0) ||
                                (row["लेख्न नसक्ने महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["लेख्न नसक्ने महिला संख्या"]) > 0) ||
                                (row["लेख्न नसक्ने तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["लेख्न नसक्ने तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level2 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 2,
                                    Male = row["लेख्न नसक्ने पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["लेख्न नसक्ने पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["लेख्न नसक्ने महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["लेख्न नसक्ने महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["लेख्न नसक्ने तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["लेख्न नसक्ने तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level2);
                            }

                            if ((row["पढन लेख्न नसक्ने पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["पढन लेख्न नसक्ने पुरुष संख्या"]) > 0) ||
                                (row["पढन लेख्न नसक्नेमहिला संख्या"] != DBNull.Value && Convert.ToInt32(row["पढन लेख्न नसक्नेमहिला संख्या"]) > 0) ||
                                (row["पढन लेख्न नसक्नेतेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["पढन लेख्न नसक्नेतेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level3 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 3,
                                    Male = row["पढन लेख्न नसक्ने पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["पढन लेख्न नसक्ने पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["पढन लेख्न नसक्नेमहिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["पढन लेख्न नसक्नेमहिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["पढन लेख्न नसक्नेतेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["पढन लेख्न नसक्नेतेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level3);
                            }

                            if ((row["आधारभूत तह पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["आधारभूत तह पुरुष संख्या"]) > 0) ||
                                (row["आधारभूत तह  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["आधारभूत तह  महिला संख्या"]) > 0) ||
                                (row["आधारभूत तह तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["आधारभूत तह तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level4 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 4,
                                    Male = row["आधारभूत तह पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["आधारभूत तह पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["आधारभूत तह  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["आधारभूत तह  महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["आधारभूत तह तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["आधारभूत तह तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level4);
                            }

                            if ((row["प्रमाणपत्रतह पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["प्रमाणपत्रतह पुरुष संख्या"]) > 0) ||
                                (row["प्रमाणपत्रतह  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["प्रमाणपत्रतह  महिला संख्या"]) > 0) ||
                                (row["प्रमाणपत्रतह तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["प्रमाणपत्रतह तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level5 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 5,
                                    Male = row["प्रमाणपत्रतह पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["प्रमाणपत्रतह पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["प्रमाणपत्रतह  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["प्रमाणपत्रतह  महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["प्रमाणपत्रतह तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["प्रमाणपत्रतह तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level5);
                            }

                            if ((row["प्रवेशिका/ S.E.E. पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["प्रवेशिका/ S.E.E. पुरुष संख्या"]) > 0) ||
                                (row["प्रवेशिका/ S.E.E.  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["प्रवेशिका/ S.E.E.  महिला संख्या"]) > 0) ||
                                (row["प्रवेशिका/ S.E.E. तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["प्रवेशिका/ S.E.E. तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level6 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 6,
                                    Male = row["प्रवेशिका/ S.E.E. पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["प्रवेशिका/ S.E.E. पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["प्रवेशिका/ S.E.E.  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["प्रवेशिका/ S.E.E.  महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["प्रवेशिका/ S.E.E. तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["प्रवेशिका/ S.E.E. तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level6);
                            }

                            if ((row["स्‍नातकउतीर्ण पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["स्‍नातकउतीर्ण पुरुष संख्या"]) > 0) ||
                                (row["स्‍नातकउतीर्ण  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["स्‍नातकउतीर्ण  महिला संख्या"]) > 0) ||
                                (row["स्‍नातकउतीर्ण तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["स्‍नातकउतीर्ण तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level7 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 7,
                                    Male = row["स्‍नातकउतीर्ण पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["स्‍नातकउतीर्ण पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["स्‍नातकउतीर्ण  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["स्‍नातकउतीर्ण  महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["स्‍नातकउतीर्ण तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["स्‍नातकउतीर्ण तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level7);
                            }

                            if ((row["स्‍नातकोत्तरउत्तीर्ण पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["स्‍नातकोत्तरउत्तीर्ण पुरुष संख्या"]) > 0) ||
                                (row["स्‍नातकोत्तरउत्तीर्ण  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["स्‍नातकोत्तरउत्तीर्ण  महिला संख्या"]) > 0) ||
                                (row["स्‍नातकोत्तरउत्तीर्ण तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["स्‍नातकोत्तरउत्तीर्ण तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level8 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 8,
                                    Male = row["स्‍नातकोत्तरउत्तीर्ण पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["स्‍नातकोत्तरउत्तीर्ण पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["स्‍नातकोत्तरउत्तीर्ण  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["स्‍नातकोत्तरउत्तीर्ण  महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["स्‍नातकोत्तरउत्तीर्ण तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["स्‍नातकोत्तरउत्तीर्ण तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level8);
                            }

                            if ((row["विद्यावारिधीहासिल पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["विद्यावारिधीहासिल पुरुष संख्या"]) > 0) ||
                                (row["विद्यावारिधीहासिल  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["विद्यावारिधीहासिल  महिला संख्या"]) > 0) ||
                                (row["विद्यावारिधीहासिल तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["विद्यावारिधीहासिल तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level9 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 9,
                                    Male = row["विद्यावारिधीहासिल पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["विद्यावारिधीहासिल पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["विद्यावारिधीहासिल  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["विद्यावारिधीहासिल  महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["विद्यावारिधीहासिल तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["विद्यावारिधीहासिल तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level9);
                            }

                            if ((row["उमेर कम पुरुष संख्या"] != DBNull.Value && Convert.ToInt32(row["उमेर कम पुरुष संख्या"]) > 0) ||
                                (row["उमेर कम  महिला संख्या"] != DBNull.Value && Convert.ToInt32(row["उमेर कम  महिला संख्या"]) > 0) ||
                                (row["उमेर कम तेस्रो लिंगी संख्या"] != DBNull.Value && Convert.ToInt32(row["उमेर कम तेस्रो लिंगी संख्या"]) > 0))
                            {
                                var level10 = new EducationEducationalLevelGroup()
                                {
                                    EducationId = educationDetailId,
                                    EducationalLevelId = 10,
                                    Male = row["उमेर कम पुरुष संख्या"] != DBNull.Value ? Convert.ToInt32(row["उमेर कम पुरुष संख्या"].ToString().Trim()) : 0,
                                    Female = row["उमेर कम  महिला संख्या"] != DBNull.Value ? Convert.ToInt32(row["उमेर कम  महिला संख्या"].ToString().Trim()) : 0,
                                    Other = row["उमेर कम तेस्रो लिंगी संख्या"] != DBNull.Value ? Convert.ToInt32(row["उमेर कम तेस्रो लिंगी संख्या"].ToString().Trim()) : 0,
                                };
                                educationalLevelGroups.Add(level10);
                            }


                        }
                        if (educationDetailSchoolGroups.Count > 0)
                        {
                            _context.EducationDetailSchoolGroups.AddRange(educationDetailSchoolGroups);
                            await _context.SaveChangesAsync();
                        }
                        if (educationalLevelGroups.Count > 0)
                        {
                            _context.EducationEducationalLevelGroups.AddRange(educationalLevelGroups);
                            await _context.SaveChangesAsync();
                        }




                        ////WaterDetail 
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }
                            var waterdetail = new WaterDetail()
                            {
                                HouseOwnerdetailId = houseid.Value,
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                WaterResourceId = GetWaterResourceId(row["१.खानेपानीको स्रोत के छ?"]?.ToString().Trim()),
                                CookingFuelId = GetCookingFuelId(row["२.       पकाउन प्रयोग हुने इन्धन के छ?"]?.ToString().Trim()),
                                CookingStoveId = GetCookingStoveId(row["३. चुल्होको प्रकार कुन छ?"]?.ToString().Trim()),
                                LightSourceId = GetLightSourceId(row["६. प्रकाश स्रोत प्रकार"]?.ToString().Trim()),
                                ToiletId = GetToiletId(row["५.शौचालयको प्रकार कस्तो छ?"]?.ToString().Trim()),
                                WasteManagementId = GetWasteManagementId(row["४. फोहोर मैला ब्यबस्थापन कसरी गर्नुहुन्छ?"]?.ToString().Trim()),
                            };
                            waterDetails.Add(waterdetail);
                        }
                        if (waterDetails.Count > 0)
                        {
                            _context.WaterDetails.AddRange(waterDetails);
                            await _context.SaveChangesAsync();
                        }





                        ////HouseDetail
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }
                            var housedetail = new HouseDetail()
                            {
                                HouseOwnerDetailId = houseid.Value,
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                HouseFloorId = GetHouseFloorID(row["१. घरको तल्ला"]?.ToString().Trim()),
                                HouseRoofId = GetRoofId(row["४.घरको छानो"]?.ToString().Trim()),
                                HouseMapId = GetHouseMapId(row["२       घर नक्सा विवरण"]?.ToString().Trim()),
                                HouseOwnershipId = GetOwnershipId(row["३.घरको स्वामित्व"]?.ToString().Trim()),
                                AnySuggestions1 = row["५.गाउँपलिकालाइ दुई मुख्य सुझाब  के दिन चाहनुहुन्छ ?"] != DBNull.Value ? row["५.गाउँपलिकालाइ दुई मुख्य सुझाब  के दिन चाहनुहुन्छ ?"].ToString().Trim() : string.Empty
                            };
                            houseDetails.Add(housedetail);
                        }
                        if (houseDetails.Count > 0)
                        {
                            _context.HouseDetails.AddRange(houseDetails);
                            await _context.SaveChangesAsync();
                        }





                        ////BalBibaha Detail
                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }
                            var balbibaha = new BalBibaha()
                            {
                                HouseOwnerDetailId = houseid.Value,
                                WardNo = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.WardNo ?? null,
                                Bihe5years = MapBooleanValue(row["१. तपाइको परिवारमा बिगत ५ वर्षमा कसैको बिवाह भयो ?"]?.ToString().Trim()),
                                Vayekovaye = row["१.१ कसको भएको ?"] != DBNull.Value ? row["१.१ कसको भएको ?"]?.ToString().Trim() : null,
                                BiheKasariVayeko = row["१.२ बिबाह कसरि भयो ?"] != DBNull.Value ? row["१.२ बिबाह कसरि भयो ?"]?.ToString().Trim() : null,
                                ChoraBiheKatiBarsa = row["१.१.१ छोराको उमेर ?"] != DBNull.Value ? Convert.ToInt32(row["१.१.१ छोराको उमेर ?"]) : 0,
                                BuhariKoUmer = row["१.१.२ बुहारीको उमेर?"] != DBNull.Value ? Convert.ToInt32(row["१.१.२ बुहारीको उमेर?"]) : 0,
                                ChoriBiheKatiBarsa = row["१.१.३. छोरीको उमेर ?"] != DBNull.Value ? Convert.ToInt32(row["१.१.३. छोरीको उमेर ?"]) : 0,
                                JwaiKoUmer = row["१.१.३. ज्वाइको उमेर ?"] != DBNull.Value ? Convert.ToInt32(row["१.१.३. ज्वाइको उमेर ?"]) : 0,
                                Santan = row["१.३  विवाहको कति पछाडी सन्तान जन्मियो ? (महिना मा राख्ने )"] != DBNull.Value ? Convert.ToInt32(row["१.३  विवाहको कति पछाडी सन्तान जन्मियो ? (महिना मा राख्ने )"]) : 0,
                                KatiSamayeSankyukta = row["१.४ विवाह पछाडी कति समय सम्म संयुक्त परिवारमा बसाइ रह्यो ?"] != DBNull.Value ? row["१.४ विवाह पछाडी कति समय सम्म संयुक्त परिवारमा बसाइ रह्यो ?"].ToString().Trim() : null,
                                OneBarsaBihe = MapBooleanValue(row["२. यस १ वर्षमा तपाईको परिवारमा कसैको विवाह भयो ?"]?.ToString().Trim()),
                                YediVayeko = row["२.१ कसको भयो ?"] != DBNull.Value ? row["२.१ कसको भयो ?"].ToString().Trim() : null,
                                KastoPrakarBihe = row["२.२ कस्तो प्रकारको विवाह थियो?"] != DBNull.Value ? row["२.२ कस्तो प्रकारको विवाह थियो?"].ToString().Trim() : null,
                                BiheGardaUmer = row["२.३ बिबाह गर्दाको उमेर कति थियो??"] != DBNull.Value ? Convert.ToInt32(row["२.३ बिबाह गर्दाको उमेर कति थियो??"]) : 0,
                                Daijo = MapBooleanValue(row["२.४ बिबाह गर्दा कुनै दाइजो लिनुभयो/दिनुभयो ?"]?.ToString().Trim()),
                                KpraptaGarnuVoo = row["२.४.१ यदी भएको भए के के प्राप्त/प्रदान भयो ?"] != DBNull.Value ? row["२.४.१ यदी भएको भए के के प्राप्त/प्रदान भयो ?"].ToString().Trim() : null,
                                BihePaxadiAdhyan = MapBooleanValue(row["२.५ विवाह पछी अध्ययनरत हुनु हुन्छ ?"]?.ToString().Trim()),
                                ChaVaneyKunTaha = row["२.५.१ कुन तह मा ?"] != DBNull.Value ? row["२.५.१ कुन तह मा ?"].ToString().Trim() : null,
                                ChainaVaneyKaran = null,
                                UmerNapugiSamasya = MapBooleanValue(row["२.६.१ कुनै कानूनी समस्याहरु आए?"]?.ToString().Trim()),
                                KsamasyaAayo = row["२.६.१.१ के के समस्याहरु आए ?"] != DBNull.Value ? row["२.६.१.१ के के समस्याहरु आए ?"].ToString().Trim() : null,
                                BihePaxadiPrajanna = MapBooleanValue(row["२.६.२  प्रजनन् सम्बन्धित कुनै समस्या आयो ?"]?.ToString().Trim()),
                                YediAayo = row["२.६.२.१ के के समस्याहरु आए ?"] != DBNull.Value ? row["२.६.२.१ के के समस्याहरु आए ?"].ToString().Trim() : null,
                                YediSanoUmer = MapBooleanValue(row["२.६.३ घरपरिवारमा कुनै समस्या आए ?"]?.ToString().Trim()),
                                AayoVaney = row["२.६.३.१ के के समस्याहरु आए ?"] != DBNull.Value ? row["२.६.३.१ के के समस्याहरु आए ?"].ToString().Trim() : null,
                                BalBibahaKoSamasya = row["२.७  बाल विवाहका कारण कस्ता समस्या भोग्नु परेको छ ?"] != DBNull.Value ? row["२.७  बाल विवाहका कारण कस्ता समस्या भोग्नु परेको छ ?"].ToString().Trim() : null,
                                BalBibahaKoBareyThaxa = MapBooleanValue(row["२.८  तपाईलाई बालविवाहको बारेमा थाहा छ"]?.ToString().Trim()),
                                BalBibahaBareyBichar = row["२.९ तपाईको विचारमा बालविवाह अन्त्य गर्न के गर्नुपर्छ होला ?"] != DBNull.Value ? row["२.९ तपाईको विचारमा बालविवाह अन्त्य गर्न के गर्नुपर्छ होला ?"].ToString().Trim() : null,
                                BalBibahaBareyKehiVannu = row["२.१० अन्त्यमा केही भन्नु पर्ने छ?"] != DBNull.Value ? row["२.१० अन्त्यमा केही भन्नु पर्ने छ?"].ToString().Trim() : null


                            };
                            balBibahaDetails.Add(balbibaha);

                        }
                        if (balBibahaDetails.Count > 0)
                        {
                            _context.BalBibahas.AddRange(balBibahaDetails);
                            await _context.SaveChangesAsync();
                        }






                        ////Multi SectorNutritionAndExtensionPage



                        foreach (DataRow row in sheet1.Rows)
                        {
                            int? houseid = row["HouseOwnerId"] != DBNull.Value ? (int?)Convert.ToInt32(row["HouseOwnerID"]) : null;
                            if (houseid == null || !houseOwnerDetails.Any(x => x.Id == houseid))
                            {
                                // Log or handle invalid HouseOwnerDetailId (e.g., skip this row)
                                Console.WriteLine($"Invalid or missing HouseOwnerDetailId: {houseid}");
                                continue;  // Skip adding this EconomicDetail if HouseOwnerDetailId is invalid
                            }


                            // Get the _index from sheet1
                            int? index = row["_index"] != DBNull.Value ? (int?)Convert.ToInt32(row["_index"]) : null;

                            // Find matching row in sheet5 based on _parent_index
                            DataRow sheet5Row = sheet5.AsEnumerable()
                                .FirstOrDefault(r => r["_parent_index"] != DBNull.Value && Convert.ToInt32(r["_parent_index"]) == index);

                            string thapKhanaKhuwaunuValue = null;
                            if (sheet5Row != null)
                            {
                                thapKhanaKhuwaunuValue = sheet5Row["४.७.२ थप खाना खुवाउनुभएको छ भने देहाय मध्ये के-के खुवाउनुभयो ?"]?.ToString().Trim();
                            }
                            var multisector = new MultisectoralNutritionAndExtension()
                            {
                                HouseOwnerDetailId = houseid.Value,
                                AnyPregnancy = MapBooleanValue(row["३.गत वर्ष २०७९ सालमा तपाईको घरमा कोही गर्भवती महिला हुनुहुन्थ्यो ?("]?.ToString().Trim()),
                                AnySleepMotherInYourHouse = MapBooleanValue(row["४.गत वर्ष २०८० सालमा तपाईको घरमा कोही गर्भवती महिला हुनुहुन्थ्यो ?("]?.ToString().Trim()),
                                AnyHivcase = MapBooleanValue(row["५ तपाइको परिवारमा HIV संक्रमित व्यक्ति हुनुहुन्छ ?"]?.ToString().Trim()),
                                IsBornChildHivinfected = MapBooleanValue(row["५.१ HIV संक्रमित आमाबाट वच्चा जन्मिएको छ ?"]?.ToString().Trim()),
                                Arvprophylaxis = MapBooleanValue(row["५.१.१ बच्चाले ARV Prophylaxis पाइका छन ?"]?.ToString().Trim()),
                                Is12YearChild = MapBooleanValue(row["६ तपाइको घरमा १२ महिना सम्मको बच्चा छ ?"]?.ToString().Trim()),
                                ChildKhopDetails = row["६.१ खोप लगाएको अवस्था कस्तो छ?"] != DBNull.Value ? row["६.१ खोप लगाएको अवस्था कस्तो छ?"]?.ToString().Trim() : null,
                                Is16YearChild = MapBooleanValue(row["७. तपाइको घरमा १६ महिना माथिको बच्चा छ ?"]?.ToString().Trim()),
                                IsKhopCard = MapBooleanValue(row["७.१ पूर्णखोप कार्ड छ ?"]?.ToString().Trim()),
                                SixMto5YbitminAkhopPatak = row["८. तपाईको घरमा ६ महिना देखि ५ वर्ष भित्रको बच्चा भए भिटामिन ए वर्षमा कति पटक खुवाउनु भयो ?"] != DBNull.Value ? row["८. तपाईको घरमा ६ महिना देखि ५ वर्ष भित्रको बच्चा भए भिटामिन ए वर्षमा कति पटक खुवाउनु भयो ?"].ToString().Trim() : null,
                                OneTo5YjukaKhopPatak = row["९. तपाईको घरमा १-५ वर्ष भित्रको बच्चा भए जुकाको औषधी वर्षमा कति पटक खुवाउनु भयो?"] != DBNull.Value ? row["९. तपाईको घरमा १-५ वर्ष भित्रको बच्चा भए जुकाको औषधी वर्षमा कति पटक खुवाउनु भयो?"].ToString().Trim() : null,
                                Is24Mchaild = MapBooleanValue(row["१०. तपाईको घरमा २४ महिना सम्मको बच्चा छ ?"]?.ToString().Trim()),
                                IsWeighted = MapBooleanValue(row["१०.१ तौल लिने गर्नुभएको छ ?"]?.ToString().Trim()),
                                HowManyTimes = row["१०.१.१. तौल कसरी लिने गर्नुभएको छ ?"] != DBNull.Value ? row["१०.१.१. तौल कसरी लिने गर्नुभएको छ ?"].ToString().Trim() : null,
                                WeightThau = row["१०.१.२ तौल कहाँ लिने गर्नु भएको छ ?"] != DBNull.Value ? row["१०.१.२ तौल कहाँ लिने गर्नु भएको छ ?"].ToString().Trim() : null,
                                AnyChildHealthIssue = MapBooleanValue(row["११.तपाईको बच्चालाई स्वास्थ्यकर्मीले पोषण कम भएर रातो वा पहेलो रंगमा परेको भनि सल्लाह दिनुभएको छ?"]?.ToString().Trim()),
                                HealthIssuColorType = row["११.१ कुन रंग परेको छ ?"] != DBNull.Value ? row["११.१ कुन रंग परेको छ ?"].ToString().Trim() : null,
                                EatNunType = row["१२. तपाईले खानामा कुन नुन प्रयोग गर्नुहुन्छ ?"] != DBNull.Value ? row["१२. तपाईले खानामा कुन नुन प्रयोग गर्नुहुन्छ ?"].ToString() : null,
                                AnyDiarrheaIssue = MapBooleanValue(row["१३. तपाईको घरका बालबालिकालाई विगतमा झाडापखला लागेको थियो ?"]?.ToString().Trim()),
                                DiarrheaTimeEatJinkChaki = MapBooleanValue(row["१३.१ झाडापखाला लागेको बेला जिंक चक्की खुवाउनुभयो ?"]?.ToString().Trim()),
                                DiarrheaTimeEatDays = row["१३.१.१ कति दिन सम्म जिंक चक्की खुवाउनुभयो ?"] != DBNull.Value ? Convert.ToInt32(row["१३.१.१ कति दिन सम्म जिंक चक्की खुवाउनुभयो ?"].ToString().Trim()) : 0,
                                DiarrheaTimeEatPunJaliyaJhol = MapBooleanValue(row["१३.२ झाडापखाला लागेको बेला बच्चालाई पूनर्जलीय झोल खुवाउनुभयो ?"]?.ToString().Trim()),
                                IsNotGoToSchool5To14Child = MapBooleanValue(row["१४. तपाईको घरमा ५-१४ वर्षको विद्यालय नजाने बच्चाहरु छन ?"]?.ToString().Trim()),
                                CurrentAddeess = row["१४.१ हाल कहाँ छन ?"] != DBNull.Value ? row["१४.१ हाल कहाँ छन ?"].ToString().Trim() : null,
                                Child10To19Ypresent = MapBooleanValue(row["१५. तपाईको घरमा १०-१९ वर्षको किशोर किशोरीहरु छन ?"]?.ToString().Trim()),
                                BoysCount = row["१५.१ किशोरको संख्या"] != DBNull.Value ? Convert.ToInt32(row["१५.१ किशोरको संख्या"].ToString().Trim()) : 0,
                                GirlsCounts = row["१५.२ किशोरीको संख्या"] != DBNull.Value ? Convert.ToInt32(row["१५.२ किशोरीको संख्या"].ToString().Trim()) : 0,
                                IsChildAfter1To8EductionStop = MapBooleanValue(row["१६. तपाइको घरमा आधारभुत तहमा (कक्षा १-८)शिक्षा पश्चात विधालय नगएका वालवालिका छन ?"]?.ToString().Trim()),
                                ChildAddreee = row["१६.१ उनीहरु अहिले के गर्छन ?"] != DBNull.Value ? row["१६.१ उनीहरु अहिले के गर्छन ?"].ToString().Trim() : null,
                                ChildSipmulkTalim = MapBooleanValue(row["१६.२ उनीहरुले सिपमुलक तालिम लिएका छन ?"]?.ToString().Trim()),
                                TalimName = row["१६.२.१ सिपमुलक तालिमको नाम"] != DBNull.Value ? row["१६.२.१ सिपमुलक तालिमको नाम"].ToString().Trim() : null,
                                AnyViolenceInYourFamily = MapBooleanValue(row["१७. तपाइको घरका वालवालिकाहरु विरुद्ध घरपरिवार,समुदायमा वा सार्वजनिक स्थलमा देहायको मध्ये कुनै हिंसा भएको छ ? वालवालिकाहरुलाइ सोध्ने)"]?.ToString().Trim()),
                                ViolenceType = row["१७.१ हिंसाको प्रकार?"] != DBNull.Value ? row["१७.१ हिंसाको प्रकार?"].ToString().Trim() : null,
                                ViolenceRegister = row["१७.२ उजुरि दिन कहा जानुभयो ?"] != DBNull.Value ? row["१७.२ उजुरि दिन कहा जानुभयो ?"].ToString().Trim() : null,
                                LadisRajashwala = row["१८. तपाईको परिवारको महिला रजश्वला भएको बेला घरपरिवारमा कस्तो अवस्थामा रहनुहुन्छ"] != DBNull.Value ? row["१८. तपाईको परिवारको महिला रजश्वला भएको बेला घरपरिवारमा कस्तो अवस्थामा रहनुहुन्छ"].ToString().Trim() : null,
                                AnyUpToThreeYearAnyMarrage = MapBooleanValue(row["२०. गएको ३ वर्ष भित्र तपाईको परिवारमा कसैको बिबाह भएको छ ?"]?.ToString().Trim()),
                                AnySunoloPresentDayAama = MapBooleanValue(row["२१ .  तपाईको परिवारमा सुनौलो हजार दिनको आमा हुनुहुन्छ ?"]?.ToString().Trim()),
                                SunoloTimeKahneKuraChalFul = MapBooleanValue(row["२१.१ सुनौलो हजार दिनका सदस्यहरु (श्रीमान, श्रीमती, सासु, बुहारी) बीच पोषिलो खानेकुरा र प्रजनन स्वास्थ्य सम्बन्धि छलफल गर्नुभएको ?"]?.ToString().Trim()),
                                AnyCasualtiesDuringCovid = MapBooleanValue(row["२२. गएको ५ बर्षमा तपाईको परिवारमा कसैको कोभिडको कारणले मृत्यु भएको छ ?"]?.ToString().Trim()),
                                CasualtiesCount = row["२२.मृत्यु भएको संख्या  ?"] != DBNull.Value ? Convert.ToInt32(row["२२.मृत्यु भएको संख्या  ?"].ToString().Trim()) : 0,
                                AnyCovidDose = MapBooleanValue(row["२३. कोभिडको Vaccination लगाउनु भएको छ ?"]?.ToString().Trim()),
                                OuterMemberPresentInOurFamily = MapBooleanValue(row["२४. तपाईको घरमा कहिलेकाँही अपरिचित बालबालिकाहरुलाई आश्रय दिने गर्नु भएको छ ?"]?.ToString().Trim()),
                                AnyDisaster = MapBooleanValue(row["२५. तपाईको परिवार कुनै प्रकोपमा पर्नुभएको छ ?"]?.ToString().Trim()),
                                DisasterType = row["२५.१ कस्तो प्रकोप बाट प्रभावित हुनुभयो ?"] != DBNull.Value ? row["२५.१ कस्तो प्रकोप बाट प्रभावित हुनुभयो ?"].ToString().Trim() : null,
                                FloodDisasterWaterJach = MapBooleanValue(row["२५.१.१. बाढीपहिरो बाट प्रभावित भएको भए पानीको गुणस्तर परीक्षण गराउनुभयो ?"]?.ToString().Trim()),
                                FloodDisasterjachDate = row["२५.१.१.१. गुणस्तर परीक्षण गराउनुभएको मिति ?"] != DBNull.Value ? row["२५.१.१.१. गुणस्तर परीक्षण गराउनुभएको मिति ?"].ToString().Trim() : null,
                                IsDrinkingWaterAvilable = MapBooleanValue(row["२६. तपाईको घरमा चौबिसै घण्टा पिउने पानीको उपलब्धता छ ?"]?.ToString().Trim()),
                                DrinkingWaterShrot = row["२७. तपाईको परिवारको खानेपानीको मुख्य श्रोत कुन हो ?"] != DBNull.Value ? row["२७. तपाईको परिवारको खानेपानीको मुख्य श्रोत कुन हो ?"].ToString().Trim() : null,
                                DrinkingWaterQualityCheck = MapBooleanValue(row["२८. तपाईको घरको पानीको गुणस्तर परिक्षण गराउनुभएको छ?"]?.ToString().Trim()),
                                DrinkingWaterQualityCheckDate = row["२८.१ गुणस्तर परीक्षण गराउनुभएको मिति ?"] != DBNull.Value ? row["२८.१ गुणस्तर परीक्षण गराउनुभएको मिति ?"].ToString().Trim() : null,
                                DrinkingWaterQualityCheckTime = row["२८.२  गुणस्तर परीक्षण गराउनुभएको भए कति अवधिमा गराउनुहुन्छ?"] != DBNull.Value ? row["२८.२  गुणस्तर परीक्षण गराउनुभएको भए कति अवधिमा गराउनुहुन्छ?"].ToString().Trim() : null,
                                ToilatType = row["२९. तपाईको घरको शौचालयको अवस्था कस्तो छ ?"] != DBNull.Value ? row["२९. तपाईको घरको शौचालयको अवस्था कस्तो छ ?"].ToString().Trim() : null,
                                ToliteCleaningTime = row["२९.१ तपाईको घरको शौचालय कति अवधिमा सरसफाई गर्नुहुन्छ ?"] != DBNull.Value ? row["२९.१ तपाईको घरको शौचालय कति अवधिमा सरसफाई गर्नुहुन्छ ?"].ToString().Trim() : null,
                                SabunPaniLeHandWashBani = row["३० साबुनपानीले हात धुने बानी निम्न मध्ये कुन-कुन अवस्थामा गर्नुहुन्छ ?"] != DBNull.Value ? row["३० साबुनपानीले हात धुने बानी निम्न मध्ये कुन-कुन अवस्थामा गर्नुहुन्छ ?"].ToString().Trim() : null,
                                GharayahiKhanePaniRealtedTraning = MapBooleanValue(row["३१. घरायसी खानेपानी पिउन योग्य छ छैन भनेर कुनै संस्थाले तपाईलाई हालसालै वा यो भन्दा अगाडी परिक्षण सम्बन्धि तालिम दिएको छ ?"]?.ToString().Trim()),
                                IsHouseRanted = MapBooleanValue(row["३२. तपाईको घरमा भाडा सुकाउने चाँङ, जुठ्यान निर्माण भएको छ ?"]?.ToString().Trim()),
                                HouseRentType = row["३२.१ तपाईको घरमा भाडा सुकाउने चाँङ, जुठ्यान निर्माण भएको प्रकार ?"] != DBNull.Value ? row["३२.१ तपाईको घरमा भाडा सुकाउने चाँङ, जुठ्यान निर्माण भएको प्रकार ?"].ToString().Trim() : null,
                                UsedWaterUseForOtherUse = MapBooleanValue(row["३३. तपाईले घरधन्दा वा हातखुट्टा धोएको पानीलाई थप अरु ठाउँमा प्रयोग गर्नुभएको छ ?"]?.ToString().Trim()),
                                UsedWaterUseForOtherUseType = row["३३.१ कसरी प्रयोग गर्नुहुन्छ ?"] != DBNull.Value ? row["३३.१ कसरी प्रयोग गर्नुहुन्छ ?"].ToString().Trim() : null,
                                IsKaresabariAvilable = MapBooleanValue(row["३४.  के तपाईको घरमा करेसाबारी छ ?"]?.ToString().Trim()),
                                KaresabariArea = row["३४.१ करेशाबारी  अन्दाजी कति क्षेत्रफलमा करेशाबारी रहेको छ ?"] != DBNull.Value ? row["३४.१ करेशाबारी  अन्दाजी कति क्षेत्रफलमा करेशाबारी रहेको छ ?"].ToString().Trim() : null,
                                HowToAvilableFreshVegitable = row["३४.१ तपाईले आफूलाई आवश्यक ताजा तरकारी कसरी जुटाउनु हुन्छ ?"] != DBNull.Value ? row["३४.१ तपाईले आफूलाई आवश्यक ताजा तरकारी कसरी जुटाउनु हुन्छ ?"].ToString().Trim() : null,
                                AreYourFamilyEatProperly = MapBooleanValue(row["३५.के तपाईको परिवारले नियमित रुपमा सागसब्जी, अन्न, गेडागुडि तथा माछामासु पर्याप्त मात्रामा खाने"]?.ToString().Trim()),
                                MassuShrot = row["३६. तपाईको परिवारको लागि माछामासुको आवश्यकता पूर्ति गर्ने स्रोत के हो ?"] != DBNull.Value ? row["३६. तपाईको परिवारको लागि माछामासुको आवश्यकता पूर्ति गर्ने स्रोत के हो ?"].ToString().Trim() : null,
                                AnyCooperative = MapBooleanValue(row["३७. के तपाईको परिवारका कुनै सदस्य कृषक समूह अथवा सहकारी संस्थामा आवद्ध हुनुहुन्छ ?"]?.ToString().Trim()),
                                CooperativeType = row["३७.१ कति वटा समुहमा आवद्द हुनुहुन्छ ?"] != DBNull.Value ? row["३७.१ कति वटा समुहमा आवद्द हुनुहुन्छ ?"].ToString().Trim() : null,
                                AnyRegionalTalim = MapBooleanValue(row["३८. के तपाईले अथवा तपाईको घर परिवारबाट स्थानीय स्तरमा पाईने रैथाने बाली प्रवर्द्धन सम्बन्धि सचेतनामुलक तालिम कार्यक्रममा सहभागी हुनु भएको छ ?  (नोट: रैथानेबाली कोदो, फापर)"]?.ToString().Trim()),
                                AnyNaturalMedicialKnowlage = MapBooleanValue(row["४०. के तपाईलाई जैविक बिषादीको बारेमा केही जानकारी छ ?"]?.ToString().Trim()),
                                AnyKnowlageOfOrganicMatter = MapBooleanValue(row["४१. . के तपाईलाई प्राङगारिक मल बारे थाहा छ?"]?.ToString().Trim()),
                                AnyUseOfNaturalSewage = MapBooleanValue(row["४१.१ हाल तपाईको खेतबारिमा प्राङगरिक मल प्रयोग गर्नुहुन्छ?"]?.ToString().Trim()),
                                AnyUseOfChemicalFertilizer = MapBooleanValue(row["४२. के तपाई रासायनिक मल प्रयोग गर्नुहुन्छ ?"]?.ToString().Trim()),
                                ChemicalFertilizerName = row["४२.१ कुन मल प्रयोग गर्नुहुन्छ?"] != DBNull.Value ? row["४२.१ कुन मल प्रयोग गर्नुहुन्छ?"].ToString().Trim() : null,
                                IsBuyVegitableInMarket = MapBooleanValue(row["४४. के तपाई बजारबाट तरकारी / फलफुल  खरिद गरेर उपयोग गर्नुहुन्छ ?"]?.ToString().Trim()),
                                AnyHouseForAminal = MapBooleanValue(row["४६.तपाईको घरमा पशुपंक्षी पाल्दा खोर वा गोठ बनाएर पाल्न भएको छ ?"]?.ToString().Trim()),
                                AnimalHouseType = row["४६.१ कस्तो प्रकारको छ ?"] != DBNull.Value ? row["४६.१ कस्तो प्रकारको छ ?"].ToString().Trim() : null,
                                ConsumeMilkAndMilkProduct = MapBooleanValue(row["४७. तपाई आफ्नो घरपरिवारमा दुध वा दुधबाट बनेका खानेकुरा दिनहुँ खाने गर्नुभएको छ ?("]?.ToString().Trim()),
                                MilkAndMilkProductMedium = row["४७.१ दुधबाट बनेको खानेकुरा उपभोग गरेको भए आफ्नै घरबाट उत्पादन भएको हो कि खरिद गर्नुभएको हो?"] != DBNull.Value ? row["४७.१ दुधबाट बनेको खानेकुरा उपभोग गरेको भए आफ्नै घरबाट उत्पादन भएको हो कि खरिद गर्नुभएको हो?"].ToString().Trim() : null,
                                MilkAndMilkProductLiter = row["४७.१.१ दैनिक कति परिमाणमा खरिद गर्नुहुन्छ ?"] != DBNull.Value ? row["४७.१.१ दैनिक कति परिमाणमा खरिद गर्नुहुन्छ ?"].ToString().Trim() : null,
                                AnyAnimalForMilkProduce = MapBooleanValue(row["४८.तपाईको घरको पशुधनबाट दैनिक दुध उत्पादन हुन्छ ?"]?.ToString().Trim()),
                                MilkInLiter = row["४८.१ तपाईको घरको पशुधनबाट दैनिक दुध उत्पादन कति गर्नुहुन्छ ?"] != DBNull.Value ? row["४८.१ तपाईको घरको पशुधनबाट दैनिक दुध उत्पादन कति गर्नुहुन्छ ?"].ToString().Trim() : null,
                                SellMillInLiter = row["४८.२ उत्पादित दुध कति लिटर बिक्री गर्नुहुन्छ ?"] != DBNull.Value ? row["४८.२ उत्पादित दुध कति लिटर बिक्री गर्नुहुन्छ ?"].ToString().Trim() : null,
                                MassuCossumeDays = row["४९. तपाईको घरमा कति दिनको अन्तरमा मासु खाने गर्नुभएको छ ?("] != DBNull.Value ? row["४९. तपाईको घरमा कति दिनको अन्तरमा मासु खाने गर्नुभएको छ ?("].ToString().Trim() : null,
                                MassuConsumeInKg = row["५०. तपाईको घरमा एकपटक मासु खरिद गर्दा सरदर कति केजी ल्याउने गर्नुभएको छ ?"] != DBNull.Value ? row["५०. तपाईको घरमा एकपटक मासु खरिद गर्दा सरदर कति केजी ल्याउने गर्नुभएको छ ?"].ToString().Trim() : null,
                                IsConssumeEggs = MapBooleanValue(row["५१.तपाईको परिवारमा नियमित खानामा अण्डाको प्रयोग गर्ने गरेको छ ?"]?.ToString().Trim()),
                                ConssumeEggsTime = row["५१.१ कसरि प्रयोग गर्नुहुन्छ ?"] != DBNull.Value ? row["५१.१ कसरि प्रयोग गर्नुहुन्छ ?"].ToString().Trim() : null,
                                AreYouVisitGovermentOffice = MapBooleanValue(row["५२. तपाई कुनै काम लिएर गाउँपालिका/वडा कार्यालय जानुभएको छ ?"]?.ToString().Trim()),
                                FeedBackForEmployee = row["५२.१ कर्मचारीहरुले कस्तो सहयोग गर्नुभयो ?"] != DBNull.Value ? row["५२.१ कर्मचारीहरुले कस्तो सहयोग गर्नुभयो ?"].ToString().Trim() : null,
                                OfficeService = row["५२.२ गाउँपालिका वा वडा कार्यालयमा सेवा लिन जाँदा तपाईले कतिको चाँडो सेवा पाउनुभयो ?"] != DBNull.Value ? row["५२.२ गाउँपालिका वा वडा कार्यालयमा सेवा लिन जाँदा तपाईले कतिको चाँडो सेवा पाउनुभयो ?"].ToString().Trim() : null,
                                VisitToHealthCare = MapBooleanValue(row["५३ तपाई आफ्नो नजिकको स्वास्थ्य संस्थामा सेवा लिन जानुभएको छ ?"]?.ToString().Trim()),
                                FeedbackAboutHealthcareEmployee = row["५३.१ स्वास्थ्यकर्मीले तपाई प्रति कस्तो व्यवहार देखाउनुभयो ?"] != DBNull.Value ? row["५३.१ स्वास्थ्यकर्मीले तपाई प्रति कस्तो व्यवहार देखाउनुभयो ?"].ToString().Trim() : null,
                                HealthCareService = row["५३.२ स्वास्थ्य संस्थामा सेवा पाउन कति समय लाग्यो ?"] != DBNull.Value ? row["५३.२ स्वास्थ्य संस्थामा सेवा पाउन कति समय लाग्यो ?"].ToString().Trim() : null,
                                AnyOtherIncomeSource = MapBooleanValue(row["५७. तपाईको परिवारमा मुख्य आम्दानीको स्रोतको अतिरिक्त अन्य आम्दानीको स्रोत पनी रहेको छ ?"]?.ToString().Trim()),
                                OtherIncomeSourceName = row["५७.१ कुन-कुन स्रोतबाट आम्दानी हुन्छ ?"] != DBNull.Value ? row["५७.१ कुन-कुन स्रोतबाट आम्दानी हुन्छ ?/कृषि / पशुपालन "].ToString().Trim() : null,
                                OtherIncomeYearly = row["५७.२ उक्त स्रोतहरुबाट वार्षिक कति आम्दानी हुन्छ ?"] != DBNull.Value ? row["५७.२ उक्त स्रोतहरुबाट वार्षिक कति आम्दानी हुन्छ ?"].ToString().Trim() : null,
                                FamilyBusiness = MapBooleanValue(row["५८. तपाईको परिवारले कुनै किसिमको व्यापार व्यवसाय, उद्योग गर्नु भएको छ ?"]?.ToString().Trim()),
                                FamilyBusinessNo = row["५८.१ कति ओटा छ ?"] != DBNull.Value ? Convert.ToInt32(row["५८.१ कति ओटा छ ?"].ToString().Trim()) : 0,
                                FamilyEmployment = MapBooleanValue(row["५९. तपाईको परिवारको कोही रोजगारीमा हुनुहुन्छ ?"]?.ToString().Trim()),
                                FamilyEmploymentName = row["५९.१ कुन क्षेत्रमा काम गर्दै हुनु हुन्छ ?"] != DBNull.Value ? row["५९.१ कुन क्षेत्रमा काम गर्दै हुनु हुन्छ ?"].ToString().Trim() : null,
                                FamilyEmploymentDuration = row["५९.२ उक्त क्षेत्रका काम गर्नु भएको कति दिन/वर्ष भयो ?"] != DBNull.Value ? row["५९.२ उक्त क्षेत्रका काम गर्नु भएको कति दिन/वर्ष भयो ?"].ToString().Trim() : null,
                                FamilyProductQuality = MapBooleanValue(row["६० तपाईले उत्पादन गरेको खाद्यान्न स्वास्थ्य र पोषणको दृष्टिकोणले उपर्युक्त छ?"]?.ToString().Trim()),
                                FamilyProductEnough = MapBooleanValue(row["६१ तपाईले उत्पादन गरेको खाद्यान्नले तपाईको परिवारलाई खान पुग्छ ?"]?.ToString().Trim()),
                                SchoolC23 = null,
                                AnyLadisKamalari = MapBooleanValue(row["१९. तपाईको परिवारको कुनै महिलालाई कमलरी राख्नु भएको छ ?"]?.ToString().Trim()),
                                UpacharWhere = row["२.उपचार गर्न कहाँ जानुहुन्छ?"] != DBNull.Value ? row["२.उपचार गर्न कहाँ जानुहुन्छ?"].ToString().Trim() : null,
                                IsUseNaturalMedicial = false,
                                HowToCookFood = row["४३. तपाईको घरमा खाना पकाउन कस्तो किसिमको चुलो प्रयोग गर्नुहुन्छ ?"] != DBNull.Value ? row["४३. तपाईको घरमा खाना पकाउन कस्तो किसिमको चुलो प्रयोग गर्नुहुन्छ ?"].ToString().Trim() : null,
                                ConssumeEggCount = row["५१.२ कति परिणाममा गर्नुहुन्छ ?"] != DBNull.Value ? row["५१.२ कति परिणाममा गर्नुहुन्छ ?"].ToString().Trim() : null,
                                AnySuggestions = row["५४. गाउँपालिका तथा वडा कार्यालयलाई दईवटा मुख्य सुझाव के दिन चाहनुहुन्छ ?"] != DBNull.Value ? row["५४. गाउँपालिका तथा वडा कार्यालयलाई दईवटा मुख्य सुझाव के दिन चाहनुहुन्छ ?"].ToString().Trim() : null,
                                AnySuggestions1 = null,
                                IncomeShrotAgriculture = row["५५. तपाईको परिवारको मुख्य आम्दानिको स्रोत के हो ?"] != DBNull.Value ? row["५५. तपाईको परिवारको मुख्य आम्दानिको स्रोत के हो ?"].ToString().Trim() : null,
                                IncomeYearly = row["५६. तपाईको परिवारमा उक्त स्रोतबाट वार्षिक अनुमानित आम्दानी कति हुन्छ ?"] != DBNull.Value ? row["५६. तपाईको परिवारमा उक्त स्रोतबाट वार्षिक अनुमानित आम्दानी कति हुन्छ ?"].ToString().Trim() : null,
                                IsBuyFruitsInMarket = MapBooleanValue(row["४५. के तपाई बजारबाट फलफुल खरिद गरेर प्रयोग गर्नु हुन्छ ?"]?.ToString().Trim()),
                                ThapKhanaKhuwaunu = thapKhanaKhuwaunuValue,
                            };

                            multiSectors.Add(multisector);
                        }
                        if (multiSectors.Count > 0)
                        {
                            _context.MultisectoralNutritionAndExtensions.AddRange(multiSectors);
                            await _context.SaveChangesAsync();
                        }







                        ////Pregnancy Details and sleeping mother and houseownerfamily details



                        var houseOwnerIndexMapping = new Dictionary<int, int>();

                        foreach (DataRow row in sheet1.Rows)
                        {
                            // Assuming _index is a column in sheet1
                            if (row["_index"] != DBNull.Value)
                            {
                                int index = Convert.ToInt32(row["_index"]);
                                int houseOwnerId = houseOwnerDetails.FirstOrDefault(x => x.Name == row["१.घरमुलीको नाम थर"]?.ToString())?.Id ?? 0;

                                if (houseOwnerId != 0)
                                {
                                    houseOwnerIndexMapping[index] = houseOwnerId;
                                }
                            }
                        }



                        ////pregnancy Details

                        foreach (DataRow row in sheet4.Rows)
                        {
                            if (row["_parent_index"] != DBNull.Value)
                            {
                                int parentIndex = Convert.ToInt32(row["_parent_index"]);

                                // Use the parent index to get the corresponding HouseOwnerId
                                if (houseOwnerIndexMapping.TryGetValue(parentIndex, out int houseOwnerId))
                                {

                                    int garbhaRekhaPatak = 0;
                                    if (row["३.१.२ गर्भ रहेको पटक"] != DBNull.Value)
                                    {
                                        string garbhaValue = row["३.१.२ गर्भ रहेको पटक"].ToString().Trim();

                                        // Try to parse the value, if not possible, set it to 0
                                        if (!int.TryParse(garbhaValue, out garbhaRekhaPatak))
                                        {
                                            garbhaRekhaPatak = 0; // Set to 0 if parsing fails
                                        }
                                    }
                                    var pregnancy = new PregnancyDetail()
                                    {
                                        GharMuliId = houseOwnerId,  // Set the HouseOwnerId as GharMuliId
                                        AmmaKoNam = row["३.१.१ गर्भवती आमाको नामथर"] != DBNull.Value ? row["३.१.१ गर्भवती आमाको नामथर"].ToString().Trim() :string.Empty,
                                        GarvRaheKoPatak = garbhaRekhaPatak,
                                        //GarvRaheKoPatak= row["३.१.२ गर्भ रहेको पटक"] != DBNull.Value ? Convert.ToInt32(row["३.१.२ गर्भ रहेको पटक"].ToString().Trim()) : 0,
                                        GarvPrachianPatak = row["३.१.३ गर्भ परिक्षण गरेको पटक (निम्न महिनामा)"] != DBNull.Value ? row["३.१.३ गर्भ परिक्षण गरेको पटक (निम्न महिनामा)"].ToString().Trim() : null,
                                        Ttkhopa = row["३.१.४ टिटि खोप लगाएको संख्या (पहिलो गर्भ भए २ डोज, दोस्रो गर्भ भए १ डोज)"] != DBNull.Value ? row["३.१.४ टिटि खोप लगाएको संख्या (पहिलो गर्भ भए २ डोज, दोस्रो गर्भ भए १ डोज)"].ToString().Trim() : null,
                                        WhatDoUeat = row["३.१.५ गर्भवती हुँदा कति दिन सम्म आईरन चक्की खानुभयो?"] != DBNull.Value ? row["३.१.५ गर्भवती हुँदा कति दिन सम्म आईरन चक्की खानुभयो?"].ToString().Trim() : null,

                                        // Add other columns for pregnancy details here...
                                    };
                                    pregnancyDetails.Add(pregnancy);
                                }
                            }
                        }
                        if (pregnancyDetails.Count > 0)
                        {
                            _context.PregnancyDetails.AddRange(pregnancyDetails);
                            await _context.SaveChangesAsync();
                        }





                        ////Sleeping MotherDetails
                        foreach (DataRow row in sheet5.Rows)
                        {
                            if (row["_parent_index"] != DBNull.Value)
                            {
                                int parentIndex = Convert.ToInt32(row["_parent_index"]);

                                // Use the parent index to get the corresponding HouseOwnerId
                                if (houseOwnerIndexMapping.TryGetValue(parentIndex, out int houseOwnerId))
                                {
                                    var sleepmother = new SleepMotherDetail()
                                    {
                                        GharMuliId = houseOwnerId,
                                        Name = row["४.१ गर्भवती आमाको नामथर"] != DBNull.Value ? row["४.१ गर्भवती आमाको नामथर"].ToString().Trim():string.Empty,
                                        PrasutiAddress = row["४.२ प्रसुति कहाँ गराउनुभयो?"] != DBNull.Value ? row["४.२ प्रसुति कहाँ गराउनुभयो?"].ToString().Trim() : null,
                                        PrasutiJach = row["४.३ प्रसुति जाँच (PNC Visit) देहाय बमोजिम गराए/ नगराएको?"] != DBNull.Value ? row["४.३ प्रसुति जाँच (PNC Visit) देहाय बमोजिम गराए/ नगराएको?"].ToString().Trim() : null,
                                        ChildWeight = row["४.४ बच्चा जन्मिदा कति के.जीको थियो?"] != DBNull.Value ? row["४.४ बच्चा जन्मिदा कति के.जीको थियो?"].ToString().Trim() : null,
                                        IranChakkiDays = row["४.५ आइरन चक्की कति दिन सम्म खानुभयो?"] != DBNull.Value ? row["४.५ आइरन चक्की कति दिन सम्म खानुभयो?"].ToString().Trim() : null,
                                        IsSixMonthCompleted = MapBooleanValueNotNullable(row["४.६ बच्चा ६ महिना पुगेको छ वा छैन?"]?.ToString().Trim()),
                                        IsSixMonthEatMotherMilk = MapBooleanValueNotNullable(row["४.६.१ ६ महिना सम्म आमाको दुध मात्र खुवाएको छ वा छैँन?"]?.ToString().Trim()),
                                        AfterSixMonth = MapBooleanValueNotNullable(row["४.७ ६ महिना माथिको बच्चा छ वा छैन?"]?.ToString().Trim()),
                                        ThapKhanaKoNam = row["४.७.१ ६ महिना माथिको भए थप खाना खुवाएको छ वा छैन?"] != DBNull.Value ? row["४.७.१ ६ महिना माथिको भए थप खाना खुवाएको छ वा छैन?"].ToString().Trim() : null,

                                    };
                                    sleepMotherDetails.Add(sleepmother);
                                }
                            }
                        }
                        if (sleepMotherDetails.Count > 0)
                        {
                            _context.SleepMotherDetails.AddRange(sleepMotherDetails);
                            await _context.SaveChangesAsync();
                        }






                        // Step 2: Process sheet2 to get family details and temporarily store them in a dictionary
                        var houseOwnerFamilyTemp = new Dictionary<int, HouseOwnerFamilyDetail>();

                        foreach (DataRow row in sheet2.Rows)
                        {
                            if (row["_parent_index"] != DBNull.Value)
                            {
                                int parentIndex = Convert.ToInt32(row["_parent_index"]);

                                // Use the parent index to get the corresponding HouseOwnerId
                                if (houseOwnerIndexMapping.TryGetValue(parentIndex, out int houseOwnerId))
                                {
                                    var houseownerfamily = new HouseOwnerFamilyDetail()
                                    {
                                        HouseOwnerDetailsId = houseOwnerId,
                                        Name = row["१.१ नाम, थर"] != DBNull.Value ? row["१.१ नाम, थर"].ToString().Trim() : null,
                                        Dob = row["१.२ जन्म मिति"] != DBNull.Value ? row["१.२ जन्म मिति"].ToString().Trim() : null,
                                        Dobeng = null,
                                        IsDisability = MapBooleanValueNotNullable(row["१.३ अपांगता भए/ नभएको"]?.ToString()),
                                        EducationLevelId = null,//GetEducationLevelId(row["१.४ शिक्षा"]?.ToString().Trim()),
                                        Job = row["१.५ पेशा"] != DBNull.Value ? row["१.५ पेशा"].ToString().Trim() : null,
                                        Nata = row["१.६ नाता"] != DBNull.Value ? row["१.६ नाता"].ToString().Trim() : null
                                        // Other fields from sheet2
                                    };

                                    // Temporarily store it in the dictionary to add child data later from sheet3
                                    houseOwnerFamilyTemp[parentIndex] = houseownerfamily;
                                }
                            }
                        }

                        // Step 3: Process sheet3 and update the corresponding family details with child data
                        foreach (DataRow row in sheet3.Rows)
                        {
                            if (row["_parent_index"] != DBNull.Value)
                            {
                                int parentIndex = Convert.ToInt32(row["_parent_index"]);

                                // If the family detail exists for this parent index, update it with child data
                                if (houseOwnerFamilyTemp.TryGetValue(parentIndex, out var houseOwnerFamily))
                                {
                                    houseOwnerFamily.IsChildDarta = MapBooleanValueNotNullable(row["२.१.१. ५ वर्ष मुनिको बालबालिकाको जन्म दर्ता भए/ नभएको ?"]?.ToString());
                                    houseOwnerFamily.Height = row[1] != DBNull.Value && !string.IsNullOrWhiteSpace(row[1].ToString().Trim())
                                       ? row[1].ToString().Trim()
                                       : row[3] != DBNull.Value
                                           ? row[3].ToString().Trim()
                                           : null;

                                    // Assuming weight is in column index 12 and 13, adjust index based on your dataset
                                    houseOwnerFamily.Weight = row[3] != DBNull.Value && !string.IsNullOrWhiteSpace(row[2].ToString().Trim())
                                        ? row[2].ToString().Trim()
                                        : row[4] != DBNull.Value
                                            ? row[4].ToString().Trim()
                                            : null;
                                }
                            }
                        }

                        // Step 4: Now that all data is consolidated, add all family details to the list and save them
                        if (houseOwnerFamilyTemp.Count > 0)
                        {
                            houseOwnerFamilies = houseOwnerFamilyTemp.Values.ToList();
                            _context.HouseOwnerFamilyDetails.AddRange(houseOwnerFamilies);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
            }
            return View();
        }

        private int MapValueToId(string cellValue, Dictionary<string, int> mappingDictionary, int defaultValue = 0)
        {
            if (string.IsNullOrWhiteSpace(cellValue))
                return defaultValue;

            cellValue = cellValue.Trim();
            return mappingDictionary.TryGetValue(cellValue, out int id) ? id : defaultValue;
        }

        private int? MapValueToNullableId(string cellValue, Dictionary<string, int> mappingDictionary)
        {
            if (string.IsNullOrWhiteSpace(cellValue))
                return null;

            cellValue = cellValue.Trim();
            return mappingDictionary.TryGetValue(cellValue, out int id) ? id : (int?)null;
        }

        private bool? MapBooleanValue(string cellValue)
        {
            if (string.IsNullOrWhiteSpace(cellValue))
                return null;

            // Define true and false values
            var trueValues = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "छ", "छ ", "हो","भयो","भयो ","आयो"
            };

            var falseValues = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "छैन", "हैन", "हुदैन", "होइन","भएन","भएन ","आएन"
            };

            cellValue = cellValue.Trim();

            if (trueValues.Contains(cellValue))
                return true;

            if (falseValues.Contains(cellValue))
                return false;

            return null; // For any other values
        }



        private int? GetEarthquake2072Id(string text) => text switch
        {
            "भाडा बा डेरामा" => 1,
            "आफन्तकोमा" => 2,
            "टहरा  वा छाप्रोमा" => 3,
            "असर  नपर्ने" => 4,
            "अन्य" => 5,
            _ => null
        };

        private int? GetVehicleId(string text) => text switch
        {
            "साईकल" => 1,
            "मोटरसाईकल" => 2,
            "ट्याक्सी, जिप" => 3,
            "बस, ट्रक" => 4,
            "ट्राक्टर" => 5,
            "अन्य" => 6,
            "मोटरसाईकल ट्याक्सी, जिप" => 7,
            "मोटरसाईकल ट्राक्टर" => 8,
            "साईकल मोटरसाईकल" => 9,
            _=>null
        };

        private int? GetHouseTypeId(string text) => text switch
        {
            "कच्ची र झुप्रो" => 1,
            "ढुंगा ,माटो र टिनको छाना /ढुंगा को छाना" => 2,
            "प्लास्टर गरिएको र टिन को छाना" => 3,
            "इटा र ढलान को छाना" => 4,
            "ढलान फ्रेम स्टकचर" => 5,
            "अन्य" => 6,
            _=>null
        };

        private int? GetSkillTypeId(string text) => text switch
        {
            "डाक्टर" => 1,
            "इन्जिनियर" => 2,
            "वकिल" => 3,
            "ईलेक्त्रिसियिन" => 4,
            "टेक्निसियन" => 5,
            "कम्प्युटर इन्जिनियर" => 6,
            "सिलाई बुनाई, बुटिक ब्युटीसियन" => 7,
            "ड्राइभर" => 8,
            "अन्य" => 9,
            "test1" => 10,
            _=>null
        };

        private int? GetNaturalDisasterId(string text) => text switch
        {
            "पहिरो" => 1,
            "बाडी" => 2,
            "महामारी" => 3,
            "अन्य" => 4,
            _=>null
        };

        private int GetGenderId(string text) => text switch
        {
            "पुरुष" => 1,
            "महिला" => 2,
            "तेस्रो लिंगी" => 3
        };







        private bool MapBooleanValueNotNullable(string value)
        {
            var trueValues = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "छ", "छ ", "हो","भयो","भयो ","आयो"
            };

            return trueValues.Contains(value?.Trim());
        }

        private int GetReligionID(string text) => text switch
        {
            "हिन्दु" => 1,
            "बौद्ध" => 2,
            "क्रिस्चियन" => 3,
            "मुसलमान" => 4,
            "किरात" => 5,
            "अन्य" => 6,
            _ => 6
        };
        private int GetLanguageId(string text) => text switch
        {
            "नेपाली" => 1,
            "नेवारी" => 2,
            "मगर" => 3,
            "गुरुङ" => 4,
            "तामांग" => 5,
            "मुस्लिम" => 6,
            "थारु" => 7,
            "लिम्बु" => 8,
            "राई" => 9,
            "अन्य" => 10,
            _ => 10
        };
        private int GetMonthlyIncomeID(string text) => text switch
        {
            "·  ५०००  भन्दा कम" => 1,
            "·         ५००० देखि १००००" => 2,
            "·         १००००देखि २००००" => 3,
            "·         २००००देखि ३००००" => 4,
            "·         ३०००० देखि ४००००" => 5,
            "·         ४०००० देखि ५००००" => 6,
            "·         ५००००देखि ६००००" => 10,
            "·         ६००००देखि ७००००" => 7,
            "·         ७००००देखि ८००००" => 11,
            "·         ८०००० देखि ९०,०००" => 12,
            "७०००० देखि १०००००" => 8,
            "·         ९००००देखि १००००००" => 13,
            "·         १००००००मथि" => 9,
            _ => 14
        };
        private int GetFoodConditionId(string text) => text switch
        {
            "·         ३ महिना भन्दा कम खान पुग्ने" => 1,
            "·         ४-६ महिना खान पुग्ने" => 2,
            "·         ७-९ महिना खान पुग्ने" => 3,
            "·         १०-१२ महिना खान पुग्ने" => 4,
            "·         आफ्नो खेतिबरिको उत्पादनबाट  खान पुगने  बेचबिखन गर्न उल्लेख  नगरिएको" => 5,
            ". उल्लेख नगरीएको" => 6,
            "·         आफ्नो उत्पादन नै  नभएको" => 7,
            _ => 8
        };
        private int GetHouseFloorID(string text) => text switch
        {
            "भुइँ तल्ला" => 1,
            "एक तल्ला" => 2,
            "दुइ तल्ला" => 3,
            "तिन तल्ला" => 4,
            "चार तल्ला" => 5,
            "पांच वा पांच भन्दा बढी" => 6,
            _=>2
        };
        private int GetRoofId(string text) => text switch
        {
            "खर/पराल/छावाली" => 1,
            "जस्ता/टिन/च्यादर" => 2,
            "टायल/कपडा/झिगटी/ढुंगा" => 3,
            "सिमेंट/ढलान" => 4,
            "काठ/फल्याक" => 5,
            "माटो" => 6,
            "अन्य"=>7,
            _=>2
            
        };
        private int GetHouseMapId(string text) => text switch
        {
            "थाहा छैन" => 1,
            "नक्सा पास नभएको" => 2,
            "नक्सा बनाउनु पर्ने" => 3,
            "नक्सा पास भएको" => 4,
            "सम्पन्नताको  प्रमाणपत्र लिएको" => 5,
            _=>1
        };
        private int GetOwnershipId(string text) => text switch
        {
            "निजि" => 1,
            "भाडामा" => 2,
            "सस्थागत" => 3,
            "अन्य" => 4,
            _=>1
        };

        private int GetWaterResourceId(string text) => text switch
        {
            "व्यतिगत धारा" => 1,
            "सार्वजनिक धारा" => 2,
            "सामुदायिक धारा" => 3,
            "छिमेकीको धारा" => 4,
            "कुवा, जरुवा र ईनार" => 5,
            "नदी तथा खोला वा मुहान" => 6,
            _ => 1

        };
        private int GetCookingFuelId(string text) => text switch
        {
            "एल.पी.ग्यास" => 1,
            "दाउरा" => 2,
            "मट्टीतेल" => 3,
            "बिधुत" => 4,
            "गोबरग्यास" => 5,
            "अन्य" => 6,
            "दाउरा/एल.पी.ग्यास" => 7,
            _ => 1
        };

        private int GetCookingStoveId(string text) => text switch
        {
            "ग्यास चुल्हो" => 1,
            "धुवा रहित चुलो" => 2,
            "अगेनो वा माटोको चुल्हो" => 3,
            "स्टोभ" => 4,
            "भुसे चुल्हो" => 5,
            "बिधुत चुल्हो (हिटर)" => 6,
            "धुलोरहित चुलो" => 7,
            "धुवा रहित चुलो /ग्यास चुल्हो " => 8,
            _=>1
        };
        private int GetLightSourceId(string text) => text switch
        {
            "बिधुतलाईन" => 1,
            "मट्टीतेल" => 2,
            "सोलार" => 3,
            "बायो ग्यास" => 4,
            "अन्य" => 5,
            "सोलार / बिधुतलाईन" => 6,
            _=>6
        };

        private int GetToiletId(string text) => text switch
        {
            "चर्पी नभएको" => 1,
            "फ्लस भएको (सेफ्टिक ट्यांकी)" => 2,
            "फ्लस भएको (सार्वजनिक ढल)" => 3,
            "साधारण सौचालय" => 4,
            "बाथ रुम भएको/नभएको" => 5,
            "अन्य" => 6,
            "बाथरूम / सौचालय भएको/नभएको" => 7,
            _=>4,


        };

        private int GetWasteManagementId(string text) => text switch
        {
            "फोहोर थुपार्ने ठाउमा" => 1,
            "घरमानै लिन आउछ" => 2,
            "घरमानै लिन आउँछ"=>2,
            "आफ्नै कम्पौनटमा" => 3,
            "कम्पोष्ट मल बनाइन्छ" => 4,
            "नदी वा खोलामा" => 5,
            "अन्य" => 6,
            _=>2

        };

        private int? GetWhereAreTheyNow(string text) => text switch
        {
            "hello" => 1,
            _ => null // return null if no match
        };


        private int GetSchoolTimeId(string text)
        {
            return text switch
            {
                "१५ मीनेट भन्दा कम" => 1,
                "१५ -३० मिनेट" => 2,
                "३०-६० मीनेट" => 3,
                "१ घण्टा भन्दा बढी" => 4,
                "बालबालिका स्कूल जादैनन्" => 5,
                _ => 1
            };
        }


        private int GetEducationLevelId(string text) => text switch
        {

        };
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
//git push test