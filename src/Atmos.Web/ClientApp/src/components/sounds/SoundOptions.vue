<template>
    <section id="sound-options-page">
        <h2>Your digital place for focus. Mix different sounds and create your perfect sound environment to work and relax.</h2> 
        <p>We provide background sounds that help to mask annoying noises in order to keep you sane, improve your focus and boost your productivity.</p>
        <hr/>
        <a href="#" class="btn btn-outline-light">Sign up for free</a> <a href="#" class="btn btn-link">Give it a little try first?</a>
        <div class="row">
            <div class="col-12" id="sound-options">
                <div class="call-to-action animate__animated animate__pulse animate__delay-2s animate__infinite">
                    <p>Try to mix and match the sounds</p>
                    <div class="arrow"></div>
                </div>
                <div class="row">
                    <div class="col-4" v-for="(item) in items" v-bind:key="item.id">
                        <SoundObject :title="item.title" :description="item.description" :sources="item.audioSources" @playing="playingStarted(item)" @stopped="stoppedPlaying(item)" :icon="item.icon"/>
                    </div>
                </div>
            </div>
            <div class="col-3">
                <div class="card card-selected" v-for="(selectedItem, i) in selectedItems" v-bind:key="i">
                    <div class="card-body">
                        {{selectedItem.title}}
                    </div>
                </div>
            </div>
        </div>
        
    </section>
</template>

<script>
    import SoundObject from './SoundObject';
    
    export default {
        name: "SoundOptions",
        components: {
            SoundObject,
        },
        methods: {
            playingStarted: function (item) {
                this.selectedItems.push(item);
            },
            stoppedPlaying: function (item) {
                this.selectedItems = this.selectedItems.filter(j => j.id !== item.id);
            }
        },
        data() {
            return {
                images: {
                    icon: require('../../assets/rain.png')
                },
                selectedItems: [],
                items: [
                    {id: 4, title: 'Jungle', description: "A crackling camp fire.", audioSources: ['/audio/waves.mp3'], volume: 1, icon: require('../../assets/rain.png')},
                    {id: 5, title: 'Jungle', description: "A crackling camp fire.", audioSources: ['/audio/waves.mp3'], volume: 1, icon: require('../../assets/waves.png')},
                    {id: 6, title: 'Jungle', description: "A crackling camp fire.", audioSources: ['/audio/waves.mp3'], volume: 1, icon: require('../../assets/wind.png')},
                    {id: 7, title: 'Thunder', description: "A crackling camp fire.", audioSources: ['/audio/waves.mp3'], volume: 1, icon: require('../../assets/thunder.png')}
                ]
            }
        }
    }
</script>

<style scoped>
    h2 {
        margin-top: 6em;
    }
    #sound-options-page > p {
        margin-top: 2em;
        margin-bottom: 3em;
    }
    #sound-options-page > a {
        margin-top: 1em;
        margin-bottom: 6em;
        color: white;
    }
    #sound-options {
        margin-top: 4em;
        margin-bottom: 10em;
    }
    .card-selected {
        margin-bottom: 1em;
    }
    .call-to-action {
        text-align: center;
        margin-bottom: 1em;
    }
    .call-to-action > p {
        padding: 0;
        margin: 0;
        display: inline-block;
        position: relative;
        padding: 0;
        padding: 1em;
        padding-left: 3em;
        padding-right: 3em;
        background-color: #4DC098;
        margin-bottom: 2em;
        border-radius: 10px;
        font-weight: normal;
        font-size: 14px;
        z-index: 1000;
    }
    .call-to-action > .arrow {
        background-color: #4DC098;
        width: 30px;
        position: absolute;
        height: 30px;
        left: 0;
        right: 0;
        margin-left: auto;
        margin-right: auto;
        bottom: 23px;
        display: inline-block;
        transform: rotate(45deg);
    }
</style>