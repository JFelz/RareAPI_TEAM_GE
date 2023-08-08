using TEAMGE_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
List<User> users = new()
{
 new User()
 {
    FirstName = "John",
    LastName = "Doe",
    Email = "john@example.com",
    Bio = "Hello, I'm John.",
    UserName = "johndoe",
    Password = "password123",
    ImageUrl = "profile1.jpg"
 },
 new User()
 {
    FirstName = "Jane",
    LastName = "Smith",
    Email = "jane@example.com",
    Bio = "Nice to meet you!",
    UserName = "janesmith",
    Password = "securepwd",
    ImageUrl = "profile2.jpg"
 },
 new User()
 {
    FirstName = "Michael",
    LastName = "Johnson",
    Email = "michael@example.com",
    Bio = "Software developer.",
    UserName = "michaelj",
    Password = "123456",
    ImageUrl = "profile3.jpg"
 },
 new User()
 {
    FirstName = "Emily",
    LastName = "Brown",
    Email = "emily@example.com",
    Bio = "Nature lover.",
    UserName = "emilyb",
    Password = "pass123",
    ImageUrl = "profile4.jpg"
 },
 new User()
 {
    FirstName = "David",
    LastName = "Wilson",
    Email = "david@example.com",
    Bio = "Travel enthusiast.",
    UserName = "davidw",
    Password = "qwerty",
    ImageUrl = "profile5.jpg"
 }
 };

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

List<Reactions> reactionList = new List<Reactions>()
{
    new Reactions
    {
        Id = 1,
        Emoji = "U+1F60D", //Face Love
    },
    new Reactions
    {
        Id = 2,
        Emoji =  "U+1F914",  //Thinking Face
    },
    new Reactions
    {
        Id = 3,
        Emoji = "U+1F92F",  //Mind Blowing
    },
    new Reactions
    {
        Id = 4,
        Emoji = "U+1F621", // Angry Face
    },
};
List<PostReactions> PostReactionsList = new List<PostReactions>()
{
    new PostReactions
    {
        Id = 1,
        ReactionId = 5,
        UserId = 2,
        PostId = 3,
    },
    new PostReactions
    {
        Id = 2,
        ReactionId = 4,
        UserId = 3,
        PostId = 4,
    },
    new PostReactions
    {
        Id = 3,
        ReactionId = 3,
        UserId = 4,
        PostId = 5,
    },
    new PostReactions
    {
        Id = 4,
        ReactionId = 2,
        UserId = 1,
        PostId = 2,
    },
    new PostReactions
    {
        Id = 5,
        ReactionId = 1,
        UserId = 5,
        PostId = 1,
    },
};

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
