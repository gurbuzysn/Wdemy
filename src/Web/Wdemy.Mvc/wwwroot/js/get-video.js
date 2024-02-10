function openVideo(videoUri) {

    let videoPath = "/videos/" + videoUri;
    let videoPlayer = document.getElementById('videoPlayer');
    videoPlayer.src = videoPath;
    videoPlayer.play();
}




