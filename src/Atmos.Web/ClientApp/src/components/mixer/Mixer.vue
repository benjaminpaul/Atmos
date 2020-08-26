<template>
    <section id="mixer">
        <div class="row">
            <div class="col-12" id="sound-options">
                <CallToAction text="Try to mix and match the sounds"></CallToAction>
                <div class="row justify-content-center">
                    <div class="col-4" v-for="(item) in clips" v-bind:key="item.id">
                        <MixerClip :title="item.title" :description="item.description" :sources="item.audioSources" @playing="onSoundSelected(item)" @stopped="onSoundUnselected(item)" :icon="item.icon" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</template>

<script>
    import CallToAction from "../framework/CallToAction";
    import MixerClip from "./MixerClip";
    import {soundClipsService} from "../../services/soundclips-service";
    export default {
        name: "Mixer",
        components: {
            MixerClip,
            CallToAction
        },
        async created() {
            await this.loadClips();
        },
        computed: {
            clips: {
                get: function () {
                    return this.soundClips
                }
            }
        },
        data() {
            return {
                soundClips: [],
                selectedSoundClips: [],
            }
        },
        methods: {
            async loadClips() {
                let clips = await soundClipsService.getSoundClips();
                this.soundClips = clips.map(x => {
                    return {
                        id: x.id,
                        title: x.title,
                        description: x.description,
                        audioSources: [x.fileName],
                        icon: require(`../../assets/${x.iconFileName}`)
                    }
                })
            },
            onSoundSelected: function (soundClip) {
                console.log("Sound selected " + soundClip.title);
                this.selectedSoundClips.push(soundClip);
            },
            onSoundUnselected: function (soundClip) {
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