<template>
    <section id="mixer">
        <div class="row">
            <div class="col-12" id="sound-options">
                <CallToAction text="Try to mix and match the sounds"></CallToAction>
                <div class="row justify-content-center">
                    <div class="col-4" v-for="(item) in soundClips" v-bind:key="item.id">
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
    export default {
        name: "Mixer",
        components: {
            MixerClip,
            CallToAction
        },
        data() {
            return {
                soundClips: [
                    {
                        id: "4",
                        title: 'Rain',
                        description: "Falling rain",
                        audioSources: ['rain.mp3'],
                        icon: require('../../assets/rain.png')
                    },
                    {
                        id: "5",
                        title: 'Waves',
                        description: "Ocean Waves",
                        audioSources: ['waves.mp3'],
                        icon: require('../../assets/waves.png')
                    },
                    {
                        id: "6",
                        title: 'Birds',
                        description: "Birds",
                        audioSources: ['birds.mp3'],
                        icon: require('../../assets/birds.png')
                    },
                    {
                        id: "7",
                        title: 'Wind',
                        description: "Birds",
                        audioSources: ['wind.mp3'],
                        icon: require('../../assets/wind.png')
                    },
                    {
                        id: "7",
                        title: 'Thunder',
                        description: "Birds",
                        audioSources: ['thunder.mp3'],
                        icon: require('../../assets/thunder.png')
                    },
                ],
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