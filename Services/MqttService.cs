using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System.Text;

namespace HomeAutomationApp.Services
{
    public class MqttService
    {
        private IMqttClient _mqttClient;
        private IMqttClientOptions _options;

        public async Task ConnectAsync(string brokerAddress)
        {
            var factory = new MqttFactory();
            _mqttClient = factory.CreateMqttClient();
            _options = new MqttClientOptionsBuilder()
                .WithTcpServer(brokerAddress)
                .Build();

            _mqttClient.UseConnectedHandler(e => 
            {
                Console.WriteLine("Connected to MQTT Broker.");
            });

            await _mqttClient.ConnectAsync(_options);
        }

        public async Task PublishAsync(string topic, string payload)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(payload)
                .WithAtMostOnceQoS()
                .Build();

            await _mqttClient.PublishAsync(message);
        }
    }
}