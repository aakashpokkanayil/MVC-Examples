var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // this say hey services create all controllers and views as serviecs.
                                            // so they will be instansiated at the time of a request
                                            // for eg in runtime object of controller1 will be created and as per
                                            // http request we can invoke object of controller1.
                                            // same way every view will also created as a class as well, same way as a
                                            // controller1 view1 also can be invoked via its object
var app = builder.Build();

app.UseStaticFiles();

//app.UseRouting(); // enpoints are identifies
app.MapControllers(); // invoke all requests to repective controllers (endpoints) via attribute routing.
                      // app.UseRouting(); is not required when app.MapControllers(); is used.
                      //When a request comes in, the routing system checks the requested URL and HTTP method
                      //against the registered routes from the controllers. If a match is found,
                      //the corresponding controller action is invoked directly to handle that request.

app.Run();
