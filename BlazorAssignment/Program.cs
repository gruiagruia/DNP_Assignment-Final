using Application.DAOs;
using Application.Logic;
using BlazorAssignment.Authentication;
using BlazorAssignment.Services;
<<<<<<< HEAD
using Contracts;
=======
using BlazorAssignment.Services.Impls;
>>>>>>> origin/master
using FileData.DataAccess;
using JsonDataAccess.Context;
using Microsoft.AspNetCore.Components.Authorization;
<<<<<<< HEAD
using IPostService = Contracts.IPostService;
=======
using IPostService = Contracts.Contracts.IPostService;
>>>>>>> origin/master

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddScoped<IAuthService, AuthServiceImpl>();
builder.Services.AddScoped<IUserService, UserServiceImpl>();
builder.Services.AddScoped<IPostService,PostServiceImpl>();
builder.Services.AddScoped<JsonContext>();
builder.Services.AddScoped<IUserDAO, UserFileDAO>();
builder.Services.AddScoped<IPostDAO, PostFileDAO>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();