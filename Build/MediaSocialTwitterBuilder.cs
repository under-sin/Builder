using Builder.Products;

namespace Builder.Build;

public class MediaSocialTwitterBuilder : MediaSocialBuilder
{
    public MediaSocialTwitterBuilder()
    {
        _mediaSocial = new MediaSocial("Twitter", ConsoleColor.Cyan);
    }

    public override void BuildPost()
    {
        _mediaSocial.Post(title:"Titulo da publicação", body:"Minha primeira publicação no Twitter");
    }

    public override void BuildLike()
    {
        _mediaSocial.Like(publicacao:"publicação da Tesla");
    }
}
