Repo Steps:
1. Run the web app and open the home page in browser.
2. Click the link under Case02
3. You can see a random RequestId, which is unexpected.

When `number` is provided and `requestId` is not provided:
http://localhost:5249/GetRequest?number=12345
but the result is that requestId is filled with a random Guid value.

Video:
https://github.com/zwcloud/aspnetcore-issue-repo-model-property-filled-with-random-value/raw/refs/heads/master/video.mp4
