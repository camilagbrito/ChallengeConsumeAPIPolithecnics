using ChallengeConsumeAPI.Interfaces;
using ChallengeConsumeAPI.Request;
using ChallengeConsumeAPI.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<IInstituteService, InstituteService>();
builder.Services.AddSingleton<IHipolabsService, HipolabsService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();
//objResponse.Count

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
