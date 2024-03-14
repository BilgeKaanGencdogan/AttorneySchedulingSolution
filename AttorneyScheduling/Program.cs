using Business.Model;
using Business.Services;
using Core.Repositories.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

#region IoC Container
builder.Services.AddDbContext<Db>(options => options.UseMySQL(connectionString));
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();
builder.Services.AddScoped<ILawyerService, LawyerService>();
builder.Services.AddScoped<ILawyerTypeService, LawyerTypeService>();

builder.Services.AddScoped(typeof(RepositoryBase<>), typeof(Repository<>));

//Validator registration

builder.Services.AddScoped<IValidator<AppointmentModel>, AppointmentModelValidator>();
builder.Services.AddScoped<IValidator<ClientModel>, ClientModelValidator>();
builder.Services.AddScoped<IValidator<DocumentModel>, DocumentModelValidator>();
builder.Services.AddScoped<IValidator<LawyerModel>, LawyerModelValidator>();
builder.Services.AddScoped<IValidator<LawyerTypeModel>, LawyerTypeModelValidator>();

#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc().AddFluentValidation(fv =>
{
    fv.ImplicitlyValidateChildProperties = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
