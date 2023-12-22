using Builder.Products;

namespace Builder.Build;

public class MediaSocialFacebookBuilder : MediaSocialBuilder
{
    public MediaSocialFacebookBuilder()
    {
        _mediaSocial = new MediaSocial("Facebook", ConsoleColor.Blue);
    }

    public override void BuildPost()
    {
        _mediaSocial.Post(title:"Titulo da publicação", body:"Minha primeira publicação");
    }

    public override void BuildLike()
    {
        _mediaSocial.Like(publicacao:"publicação da Microsoft");
    }
}
