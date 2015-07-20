# Mvc6ViewComponents
Playground for view components


##

Project
```
 Mvc6ViewComponents git:(master) yo aspnet

     _-----_
    |       |    .--------------------------.
    |--(o)--|    |      Welcome to the      |
   `---------´   |   marvellous ASP.NET 5   |
    ( _´U`_ )    |        generator!        |
    /___A___\    '--------------------------'
     |  ~  |     
   __'.___.'__   
 ´   `  |° ´ Y ` 

? What type of application do you want to create? Web Application Basic [without Membership and Authorization]
? What's the name of your ASP.NET application? ViewComponentSample
...
```

Model:
```
ViewComponentSample git:(master) ✗ mkdir Models
➜  ViewComponentSample git:(master) ✗ cd Models 
➜  Models git:(master) ✗ yo aspnet:Class Product
You called the aspnet subgenerator with the arg Product
Product.cs created.
   create Product.cs
```

Service interface:
```
ViewComponentSample git:(master) ✗ mkdir Services
➜  ViewComponentSample git:(master) ✗ cd Services 
➜  Services git:(master) ✗ yo aspnet:Interface IProductService
You called the aspnet subgenerator with the arg IProductService
IProductService.cs created.
   create IProductService.cs
```

Service implementation:
```
Services git:(master) ✗ yo aspnet:Class ProductService     
You called the aspnet subgenerator with the arg ProductService
ProductService.cs created.
   create ProductService.cs
```

ViewComponent:
```
ViewComponentSample git:(master) mkdir ViewComponents
➜  ViewComponentSample git:(master) cd ViewComponents
➜  ViewComponents git:(master) yo aspnet:Class PromotedProductsViewComponent
You called the aspnet subgenerator with the arg PromotedProductsViewComponent
PromotedProductsViewComponent.cs created.
   create PromotedProductsViewComponent.c
```

Default view for ViewComponent:
```
ViewComponentSample git:(master) ✗ mkdir -p Views/Shared/Components/PromotedProducts   
➜  ViewComponentSample git:(master) ✗ cd Views/Shared/Components/PromotedProducts 
➜  PromotedProducts git:(master) ✗ yo aspnet:MvcView Default
You called the aspnet subgenerator with the arg Default
Default.cshtml created.
   create Default.cshtml
```
