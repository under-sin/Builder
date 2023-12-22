using Builder;
using Builder.Build;

MediaSocialBuilder builder;
Director director;

builder = new MediaSocialFacebookBuilder();
director = new Director(builder);

builder = new MediaSocialTwitterBuilder();
director = new Director(builder);