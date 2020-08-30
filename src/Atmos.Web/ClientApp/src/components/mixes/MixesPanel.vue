<template>
    <section id="mixes-panel" v-if="showMixPanel">
        <div class="container">
            <div class="row">
                <!-- Has mixes -->
                <div class="col-12" v-if="hasSavedMixes">
                    <p>Load environments you previously mixed</p>
                    <hr/>
                    <a href="#" class="btn btn-outline-light mix-btn" v-for="mix in mixes" :key="mix.title" @click="selectMix(mix)">{{mix.title}}</a>
                </div>
                
                <!-- No mixes -->
                <div class="col-12" v-if="!hasSavedMixes">
                    <p>You have no saved mixes yet, save your first</p>
                    <hr/>
                    <a href="#" class="btn btn-outline-light mix-btn" @click="saveMix">Save this mix</a>
                </div>
            </div>
        </div>
    </section>
</template>

<script>
    export default {
        name: "MixesPanel",
        data() {
            return {
                mixes: this.$store.state.mixes
            }
        },
        computed: {
            hasSavedMixes() {
                return this.mixes.length > 0;
            },
            showMixPanel() {
                return this.$store.state.showMixPanel
            }
        },
        methods: {
            selectMix(mix) {
                this.$store.dispatch("activateMix", mix);
            },
            saveMix() {
                console.log('Save mix');
                
            }
        }
    }
</script>

<style scoped>
    #mixes-panel {
        background: #3390DF;
        padding-top: 20px;
        padding-bottom: 20px;
    }
    
    .mix-btn {
        margin-right: 10px;
    }
</style>