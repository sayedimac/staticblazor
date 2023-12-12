using System;
using Azure;
using Azure.Data.Tables;

namespace JStatic.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
    public class BlobObject
    {
        public BlobObject(string name, string url, string customer)
        {
            blobName = name;
            blobUrl = url;
            blobCustomer = customer;
        }
        public BlobObject(string name, string url)
        {
            blobName = name;
            blobUrl = url;
        }
        public BlobObject()
        {

        }
        public string blobName { get; set; }
        public string blobUrl { get; set; }
        public string blobCustomer { get; set; }
    }
    public record Product : ITableEntity
    {
        public string RowKey { get; set; } = default!;
        public string PartitionKey { get; set; } = default!;
        public string Name { get; init; } = default!;
        public int Quantity { get; init; }
        public bool Sale { get; init; }
        public ETag ETag { get; set; } = default!;
        public DateTimeOffset? Timestamp { get; set; } = default!;
    }
}