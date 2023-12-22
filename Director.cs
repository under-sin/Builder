using Builder.Build;

namespace Builder;

public class Director
{
    public Director(MediaSocialBuilder build)
    {
        build.BuildPost();
        build.BuildLike();
    }
}
