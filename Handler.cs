using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace AwsDotnetCsharp
{
    public class Handler
    {
       public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request, ILambdaContext context)
        {
            try{
                context.Logger.LogLine("START");
                

                context.Logger.LogLine("STOP");
            }
            catch(Exception ex)
            {
                context.Logger.LogLine(ex.Message);
            }
            return new APIGatewayProxyResponse()
            {
                StatusCode = 200,
                Body = JsonConvert.SerializeObject(new { msg = "Hello World!" }),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }                
            };
        }
    }
}
