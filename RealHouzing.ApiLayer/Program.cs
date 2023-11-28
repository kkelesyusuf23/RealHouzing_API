using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.BusinessLayer.Concrete;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrete;
using RealHouzing.DataAccessLayer.EntityFramework;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IBuyingDal, EfBuyingDal>();
builder.Services.AddScoped<IBuyingService, BuyingManager>();

builder.Services.AddScoped<ICommercialDal, EfCommercialDal>();
builder.Services.AddScoped<ICommercialService, CommercialManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IContactInfoDal, EfContactInfoDal>();
builder.Services.AddScoped<IContactInfoService, ContactInfoManager>();

builder.Services.AddScoped<IExpertDal, EfExpertDal>();
builder.Services.AddScoped<IExpertService, ExpertManager>();

builder.Services.AddScoped<IFindDal, EfFinfDal>();
builder.Services.AddScoped<IFindService, FindManager>();

builder.Services.AddScoped<IJoinDal, EfJoinDal>();
builder.Services.AddScoped<IJoinService, JoinManager>();

builder.Services.AddScoped<IMapDal, EfMapDal>();
builder.Services.AddScoped<IMapService, MapManager>();

builder.Services.AddScoped<IMissionDal, EfMissionDal>();
builder.Services.AddScoped<IMissionService, MissionManager>();

builder.Services.AddScoped<INewsDal, EfNewsDal>();
builder.Services.AddScoped<INewsService, NewsManager>();

builder.Services.AddScoped<IOptionDal, EfOptionDal>();
builder.Services.AddScoped<IOptionService, OptionManager>();

builder.Services.AddScoped<IPlanDal, EfPlanDal>();
builder.Services.AddScoped<IPlanService, PlanManager>();

builder.Services.AddScoped<IProgressDal, EfProgressDal>();
builder.Services.AddScoped<IProgressService, ProgressManager>();

builder.Services.AddScoped<IPropertyDal, EfPropertyDal>();
builder.Services.AddScoped<IPropertyService, PropertyManager>();

builder.Services.AddScoped<IQuestionDal, EfQuestionDal>();
builder.Services.AddScoped<IQuestionService, QuestionManager>();

builder.Services.AddScoped<IRegisterPropertyDal, EfRegisterPropertyDal>();
builder.Services.AddScoped<IRegisterPropertyService, RegisterPropertyManager>();

builder.Services.AddScoped<ISSSDal, EfSSSDal>();
builder.Services.AddScoped<ISSSService, SSSManager>();

builder.Services.AddScoped<ITeamDal, EfTeamDal>();
builder.Services.AddScoped<ITeamService, TeamManager>();

builder.Services.AddScoped<ITourDal, EfTourDal>();
builder.Services.AddScoped<ITourService, TourManager>();

builder.Services.AddScoped<IWhatWeDoDal, EfWhatWeDoDal>();
builder.Services.AddScoped<IWhatWeDoService, WhatWeDoManager>();

builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
