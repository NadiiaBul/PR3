using System;

namespace CreationalPattern
{
    class ResourceRequestBuilder : IBuilder
    {
        private readonly ResourceRequest _resourceRequest = new ResourceRequest();
        public void SetDate(DateTime date)
        {
            _resourceRequest.Date = date;
        }

        public void SetInfo(params string[] info)
        {
            _resourceRequest.Employee = info[0];
            _resourceRequest.ListOfResources = info[1];
        }

        public void SetNumber(uint number)
        {
            _resourceRequest.Number = number;
        }
        public ResourceRequest GetResourceRequest()
        {
            return _resourceRequest;
        }
    }
}
