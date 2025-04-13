using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.projectCastroDubraska.Services.EventMQ;

public interface iRabbitMQService
{
    Task PublishMessage<T>(T message, string queueName);
}
