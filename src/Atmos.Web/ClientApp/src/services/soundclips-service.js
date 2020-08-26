class SoundClipsService {
    async getSoundClips() {
        var response = await fetch("https://localhost:5001/soundclips");
        var clips = await response.json();
        return clips;
    }
}

export let soundClipsService = new SoundClipsService();