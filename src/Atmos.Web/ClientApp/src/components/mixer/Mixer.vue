<template>
    <section id="mixer">
        <div class="row">
            <div class="col-12" id="sound-options">
                <CallToAction>Try to mix and match the sound</CallToAction>
                <p v-if="activeMix">{{activeMix.title}}</p>
                <div class="row justify-content-center">
                    <div class="col-4" v-for="(item) in calculatedMix" v-bind:key="item.id">
                        <MixerClip 
                                :title="item.title" 
                                :description="item.description" 
                                :sources="item.audioSources"
                                :icon="item.icon"
                                :clipvolume="item.volume"
                                :clip-playing="item.playing"
                                @playing="onSoundSelected(item)" 
                                @stopped="onSoundUnselected(item)" />
                    </div>
                </div>
            </div>
        </div>
        <hr/>
    </section>
</template>

<script>
    import CallToAction from "../framework/CallToAction";
    import MixerClip from "./mixerclip/MixerClip";
    
    export default {
        name: "Mixer",
        components: {
            MixerClip,
            CallToAction
        },
        created() {
            this.$store.dispatch('loadSoundClips');
        },
        computed: {
            clips() {
                return this.$store.state.soundClips;
            },
            activeMix() {
                return this.$store.state.activeMix;
            },
            calculatedMix() {
                let clips = this.clips;
                let mix = [];
                if (this.activeMix) {
                    // itterate through clips
                    // if the clip is present in activemix soundclips array
                        // set the volume and playing property.
                    clips.forEach((item) => {
                        let activeMixSettingForClip = this.activeMix.soundClips.filter(x => x.id == item.id)[0];
                        if (activeMixSettingForClip) {
                            item.volume = activeMixSettingForClip.volume;
                            item.playing = true;
                            mix.push(item);
                        } else {
                            item.volume = 0.50;
                            item.playing = false;
                            mix.push(item);
                        }
                    })
                    return mix;
                } else {
                    let c = clips.map(x => {
                        x.volume = 0.50;
                        x.playing = false;
                        return x;
                    })
                    
                    return c;
                }
            }
        },
        watch: {
        },
        data() {
            return {
                selectedSoundClips: [],
            }
        },
        methods: {
            loadMixSettings() {
                
            },
            onSoundSelected(soundClip) {
                console.log("Sound selected " + soundClip.title);
                this.selectedSoundClips.push(soundClip);
            },
            onSoundUnselected(soundClip) {
                console.log("Sound unselected " + soundClip.title);
                this.selectedSoundClips = this.selectedSoundClips.filter(s => s.id !== soundClip.id);
            }
        }
    }
</script>

<style scoped>
    #mixer {
        margin-bottom: 100px;
    }
</style>