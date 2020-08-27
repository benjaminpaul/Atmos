<template>
    <section id="mixer">
        <div class="row">
            <div class="col-12" id="sound-options">
                <CallToAction>Try to mix and match the sound</CallToAction>
                <div class="row justify-content-center">
                    <div class="col-4" v-for="(item) in clips" v-bind:key="item.id">
                        <MixerClip :title="item.title" :description="item.description" :sources="item.audioSources" @playing="onSoundSelected(item)" @stopped="onSoundUnselected(item)" :icon="item.icon" />
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
            }
        },
        data() {
            return {
                selectedSoundClips: [],
            }
        },
        methods: {
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