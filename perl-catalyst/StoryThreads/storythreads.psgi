use strict;
use warnings;

use StoryThreads;

my $app = StoryThreads->apply_default_middlewares(StoryThreads->psgi_app);
$app;

