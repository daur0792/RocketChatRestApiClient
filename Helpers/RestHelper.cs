using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;

namespace Rocker.Chat.RestApiClient.Helpers
{
    public class RestHelper
    {
        private string _baseUrl;

        public RestHelper(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public TResult Get<TResult>(string @params, Dictionary<string, string> headers = null, Dictionary<string, string> queryParams = null)
        {
            var client = new RestClient(_baseUrl);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest(@params, Method.GET);
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            if (queryParams != null)
            {
                foreach (var parameter in queryParams)
                {
                    request.AddParameter(parameter.Key, parameter.Value);
                }
            }

            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            var jsonResult = response.Content;
            var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            return result;
        }

        public TResult Post<TBody, TResult>(string @params, TBody jsonBody, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var json = JsonConvert.SerializeObject(jsonBody);
            request.AddJsonBody(json);
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            var jsonResult = response.Content;
            var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            return result;
        }

        public TResult Post<TResult>(string @params, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            var jsonResult = response.Content;
            var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            return result;
        }

        public void Post<TBody>(string @params, TBody jsonBody, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var json = JsonConvert.SerializeObject(jsonBody);
            request.AddJsonBody(json);
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            //var jsonResult = response.Content;
            //var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            //return result;
        }

        public TResult Put<TBody, TResult>(string @params, TBody jsonBody, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var json = JsonConvert.SerializeObject(jsonBody);
            request.AddJsonBody(json);
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            var jsonResult = response.Content;
            var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            return result;
        }

        public TResult Put<TResult>(string @params, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            var jsonResult = response.Content;
            var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            return result;
        }

        public void Put<TBody>(string @params, TBody jsonBody, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var json = JsonConvert.SerializeObject(jsonBody);
            request.AddJsonBody(json);
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            //var jsonResult = response.Content;
            //var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            //return result;
        }

        public TResult Delete<TBody, TResult>(string @params, TBody jsonBody, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var json = JsonConvert.SerializeObject(jsonBody);
            request.AddJsonBody(json);
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            var jsonResult = response.Content;
            var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            return result;
        }

        public TResult Delete<TResult>(string @params, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            var jsonResult = response.Content;
            var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            return result;
        }

        public void Delete<TBody>(string @params, TBody jsonBody, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(@params, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var json = JsonConvert.SerializeObject(jsonBody);
            request.AddJsonBody(json);
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }

            //var jsonResult = response.Content;
            //var result = JsonConvert.DeserializeObject<TResult>(jsonResult);

            //return result;
        }
    }
}
