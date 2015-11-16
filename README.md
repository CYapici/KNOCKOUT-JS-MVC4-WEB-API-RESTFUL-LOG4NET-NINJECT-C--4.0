
----------------------------------------------------------------------------------------------------------------------------------------------------------------

// == ASP NET MVC4 WEB API RESTFUL SERVICE (ALPHA 0.01) == // Copyright(c) Cagatay Yapici, 2015 // cagatayyapici@windowslive.com

----------------------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------  ASP NET MVC4 WEB API RESTFUL SERVICE (ALPHA 0.01) --------------------------------------------------------------------------------

APPLICATION SIMPLY PROCESSES CRUD OPERATIONS 

APPLICATION IS IN MVC ARTHITECTURE HAS A POJO MODEL AND CONTROLLER PLUS REPOSITORY LAYER 

TEST INTERFACES AND CODES 

MVC4WebApi.Tests PROJECT MAKES UNIT TESTS 

THE MAIN TEST FILE IS THE GUI  KNOCKOUT JS BASED AJAX FORM WHICH IS INDEX HTM ( I GOT IT WORKING THE GUI INDEX WITH THE URL :

DO NOT RUN APP FROM DEFAULT ROOT START IIS AND NAVIGATE TO LOCALHOST+YOUR PORT / INDEX.HTM YOU WILL GET 

SERVER ERROR IN APPLICATION ERROR .! USE THIS CONTEXT BELOW :

 http://localhost:3275/index.htm) 

THE LOG4NET IS USED IN REPOSITORY WHICH SAVES FILE AT ROOT OF PROJECT 

THE DLL FOLDER HAS 3 EXTERNAL DEPENDENCIES : NINJECT , LOG 4J , WebApiContrib.IoC.Ninject 

----------------------------------------------------------------------------------------------------------------------------------------------------------------

HOW DOES IT WORK ? 

APP CREATES MOCK REPOSITORY APPSTART -> WEBAPICONFIG CLASS IT INITALIZES DEPENDENCY INJECTION LOGGER INITIALIZATION THERE . 

APPLICATION POOL JUST ALLOWS ONE POST REQUEST FOR WEBSERVICE IF YOU NEED MORE POST COMMANDS IN SAME CONTEXT YOU HAVE TO CHANGE 

APP_START CLASSES ! 

THE REMAINING MECHANISM IS SIMPLI MODEL VIEW CONTROLLER THERE IS NOT VIEW RENDER SYSTEM IN THIS PROJECT HTML IS AJAX RESTFUL CLIENT 

OF THE WEB SERVICE 
SOME SAMPLE LINKS FROM WEB SERVICE PLEASE HAVE LOOK AT CONTROLLER OF CUSTOMER YOU WILL SEE METHOD TRY THEM IN CONTEXT OF 
http://localhost:3275/api/customers +"/" + SOME METHOD NAME FOR EXAMPLE THE BELOW LINK GETS PEOPLE 

http://localhost:3275/api/customers/1

- 
