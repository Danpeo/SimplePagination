# Simple Paginated List

List for implementing pagination.

## Example

This is how you can use Paginated List in ASP.NET Core Razor Pages

```
public async Task<IActionResult> OnGet(int? id)
    {
        AppUser? user = await _userManager.GetUserAsync(User);
        if (user != null)
        {
            List<int> subscribedCommunityIds = await _communityService.GetSubscribedCommunityIdsAsync(user);
            CommunityViewModels = await _communityService.GetSubscribedCommunitiesAsync(subscribedCommunityIds);
            
            
            List<Post> posts = await _postService.GetPostsFromSubscribedCommunitiesAsync(user);

            PostPagedList = PaginatedList<Post>.Create(posts, id ?? 1, PostsPageSize);
            
            PaginationInfo = new PaginationInfo
            {
                TotalPages = PostPagedList.TotalPages,
                CurrentPage = PostPagedList.PageIndex
            };
        }

        return Page();
    }
```
