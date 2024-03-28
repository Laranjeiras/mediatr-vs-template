namespace $rootnamespace$;

public class $servicename$Request : IRequest<$servicename$Response>
{
}

public class $servicename$Handler : IRequestHandler<$servicename$Request, $servicename$Response>
{
	public $servicename$Handler()
	{
	}

	public async Task<$servicename$Response> Handle($servicename$Request request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
