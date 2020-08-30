const LOCALSTORAGE_KEY_MIXES = "ATMOS_MIXES";

export class StoredMixSoundClip {
    volume = 0.5;
    id = null;
}

export class StoredMix {
    title = "";
    soundClips = [];
}

class MixStorageService {
    getStoredMixes() {
        let storedMix1 = new StoredMix();
        storedMix1.title = "Work from home mix";
        let clip1 = new StoredMixSoundClip();
        clip1.id = "1";
        clip1.volume = 0.80;
        storedMix1.soundClips.push(clip1);
        let clip2 = new StoredMixSoundClip();
        clip2.id = "3";
        clip2.volume = 0.60;
        storedMix1.soundClips.push(clip2);
        let storedMix2 = new StoredMix();
        storedMix2.title = "Relax mix";
        return [storedMix1,storedMix2];
        //return localStorage.getItem(LOCALSTORAGE_KEY_MIXES);
    }
    
    saveStoredMixes(mixes) {
        var jsonString = JSON.stringify(mixes);
        localStorage.setItem(LOCALSTORAGE_KEY_MIXES, jsonString);
    }
}

export let mixStorageService = new MixStorageService();