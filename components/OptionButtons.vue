<template>
	<div>
		<ProgressBar :progress="progress" />
		<div v-if="currentQuestion < questions.length">
			<h1 class="h1-votingguide">{{ questions[currentQuestion].title }}</h1>
			<p class="p-votingguide">{{ questions[currentQuestion].text }}</p>
			<div class="div-votingbuttons">
				<div class="optionbutton">
					<button @click="answerQuestion('agree')" class="buttonagree">
						<svg
							width="29"
							height="29"
							viewBox="0 0 29 29"
							fill="none"
							xmlns="http://www.w3.org/2000/svg"
							xmlns:xlink="http://www.w3.org/1999/xlink"
						>
							<rect
								width="29"
								height="29"
								transform="matrix(1 0 0 -1 0 29)"
								fill="url(#pattern0_137_20)"
							/>
							<defs>
								<pattern
									id="pattern0_137_20"
									patternContentUnits="objectBoundingBox"
									width="1"
									height="1"
								>
									<use
										xlink:href="#image0_137_20"
										transform="scale(0.0111111)"
									/>
								</pattern>
								<image
									id="image0_137_20"
									width="90"
									height="90"
									xlink:href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFoAAABaCAYAAAA4qEECAAAACXBIWXMAAAsTAAALEwEAmpwYAAACtElEQVR4nO3du49NURTH8eMVz4ZoEInX4B8Q0Sk1GiIYdHRkEp2OWqMg+ANEIfHINAoJIjEyHqNSKWQwM4SRGGJGhq+czKkk4j72WWvte36ff2DW+t19T85ZZ989RSEiIiIiIiIiIiIiFoB1wDHgKvAQGAe+4usb8AQ4BSzOdiUAi6pwHwC/iG2kXAxFToD5wHFglLyMZLOygW3V1zFXJ4vogMPAFHkbKiIDBjK4DrdiqoiABigioAGKCGiAIgKaYRDoBxYoaBsvgD6taBsTLmHTTM+AhQraxiEFbeOOgrYxrqBtzChoG2MK2sYtBW3jgIKu33D51khB1++MHlhsnw636BHcbu6xWbMOu5Vd//jUqJno6p97eHcYxKCCtjGhoHtl7mHUSHRvFHSvzD2MGoluv4Ku32OTuQfNNgpsqj1kBc1uk5AVNG8167AzpFmHHd11GNF9tBE9GRqZ1l2HjXcK2oau0UYOakXX76npHg9gObAB2AdcBj7R+z6UPZuF/I/glwKngS/07kreWEQBrAcekb9Z4D1wu7wmm28JawWwpPoJWUp93n2FBCyrvm6pDHj3FFa5CoEfiYK+691PaMC5REFPl3c63v2EBayoNgemsNe7n9CYOxwqhUveveRwiNXrBEG/8u4lPOAIaaz17iU0YB7wPEHQ/d69hAfsSRD0Re8+sgDc6zLo+949ZAHYAfzuIuiP3j1kA7jRRdCz3vVnA9gK/Oww6O/e9WcFuNJh0JPetWcFWFMdKxz73IxeAFwIuXml1zB3tnS7XnrXnR1gVwdB3/SuOzvA6g6CPu9dd5aAyTaD1ky6w6CH2wh5pnyRkPzTbgLgWhtBX/euN1vA2TbeGW73rjdbwNEWQi6HUCe8a80asPM/IX/WsD9N0Kv+CrbcBzJW7uOo/kHDyhR/x9sf2G5fDIrarFcAAAAASUVORK5CYII="
								/>
							</defs>
						</svg>
					</button>
					<p class="p-voting-text">Agree</p>
				</div>

				<div class="optionbutton">
					<button @click="answerQuestion('neither')" class="button-neither">
						<svg
							width="29"
							height="29"
							viewBox="0 0 29 29"
							fill="none"
							xmlns="http://www.w3.org/2000/svg"
							xmlns:xlink="http://www.w3.org/1999/xlink"
						>
							<rect width="29" height="29" fill="url(#pattern0_294_430)" />
							<defs>
								<pattern
									id="pattern0_294_430"
									patternContentUnits="objectBoundingBox"
									width="1"
									height="1"
								>
									<use
										xlink:href="#image0_294_430"
										transform="scale(0.0111111 0.0215909)"
									/>
								</pattern>
								<image
									id="image0_294_430"
									width="90"
									height="90"
									xlink:href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFoAAABaCAYAAAA4qEECAAAACXBIWXMAAAsTAAALEwEAmpwYAAAEeUlEQVR4nO2cT4iXRRjH33JTdu1SlIKCEsSauBClop50wxWiP1e1QylehCCPoUSCB3+7SofcZD265imIioigQxJbehCJiE6lFey6iZq2ZJZufuTBEUT2nXfe953Zmdf3+Zz28ptnvs/7zsx3npl3s0xRFEVRFEVRFEWJB/AsMAScBC4D08Ak8AMwCmwFHo/YxWYD9AFf4cY/wGHgqdj9bgxAF/A28C/luQEMAvNi60gaYAHwHfX5EeiNrSdJgBXAr/jjCvBibF1JAawELuEfWTjfiK0vCYB1wFWHxe4D4DmgG1giCQROOCb79azNAKuBqYJEfQ08bWljA/CTwyI5kLUR4BngYkGCxEE87NDWPPPG25BR0+dbxCOmk38Ycy9/d2WJACwGfi8Y7tsrtLvL/DYPibnIp5ADMwQ5mCUAMB84Y0nGTWBLjfZfBa5Z2j8lL6IvMZM5AlZ4CVARmQaATyxJ+B/Y7CHOS0ZvHp26MWyJFr7wEsDvSLuXnR5j7QBuWR7oRh9Bhi1ioph47gi3sTdAzHct8c4DT9QNsNBim2T3Nd+bGgeAfmOx8jgGPJR5RtoEPrfF9RFkjyXAe16UOAAsA/609GUsZBEIeKzA4WyqG0B2UGdzGhcLtN6bmhxkaAK/WET+XHv4uo8omZdnQnLUXTfAC5YFYTykSGCu2dXlIUX8ZaHiz9Cf9y192e0jwIeWAJ8FnBuPW+LKfN3vO25Bnx61TCF/SYm2boAnLXZPeMebGgOwDzs7sggAL1v6NOwjwIBljrpVZbubB/BmQZKHsogAX+b0a8rL6JbdUMFQru2vgdcsD1T42KVINAsHDDPVQ/7zUg8yhSbZ5+fxN/BKzSRPW9o/DfRkCZBT6fvIZ4BFDlWztyq0u70gyb95rZrVxFjfUVMPkRH4qfjtEMf4RScawy6bCGCOQ/3iQqoHpSbh4XbJZnG0bYkxpxYbLG30At8UtCG26fmszcg5WsFwv8sJYBuw1LwBq4AR4HrB72TUrI2tMwmk9uvwZlc96l8TW19SiK0zifHFudgHDMli5lu53VOXMdmJxtaTNMZn173zNje2jsYgNzKNoZdLKy7IlnZ57H43FlMw3wIcBb43Rz83zV2Mb4H93u9JKIqiKIqiKA8K3Dk1HzI2sg4TunmyYJLjk0FbvNZC/Tf5fiZja0oSAhBbU5KgiZ4dNNGR3YVjmy60y41Q0l04tlmGdrgRSroLxzbL0A43QjnGHduUacGZrA1Qjk6s6ajxEGDhMgvsoOub7VNMj/mPLFdjrcIEcBcV+uDCFXNGWv7zCuAIkVdhEhjOZeJLzqp8nep6gi1MBBI50bBEXyt1d7tColMQOZHAwy6X6ApTRwqJ7iQwfY1UCdBt7jg73akLJNKF2ViQi9yIfGx6qPa3hqHFk4C7SA7KMdgUd9H0RE/Gql00nhCWiwC1i8aTQImyk7WBEDUB3GhX0d3TW+lEbE1JQgAyRRPdGDfiQDvcRQLXsTqxNT0QbsSCugtFURRFURRFURRFUZQsbW4DDY3qbZ4QD7kAAAAASUVORK5CYII="
								/>
							</defs>
						</svg>
					</button>
					<p class="p-voting-text">Neither</p>
				</div>

				<div class="optionbutton">
					<button @click="answerQuestion('disagree')" class="button-disagree">
						<svg
							width="29"
							height="29"
							viewBox="0 0 29 29"
							fill="none"
							xmlns="http://www.w3.org/2000/svg"
							xmlns:xlink="http://www.w3.org/1999/xlink"
						>
							<rect
								width="29"
								height="29"
								transform="matrix(-1 0 0 1 29 0)"
								fill="url(#pattern0_137_19)"
							/>
							<defs>
								<pattern
									id="pattern0_137_19"
									patternContentUnits="objectBoundingBox"
									width="1"
									height="1"
								>
									<use
										xlink:href="#image0_137_19"
										transform="scale(0.0111111)"
									/>
								</pattern>
								<image
									id="image0_137_19"
									width="90"
									height="90"
									xlink:href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFoAAABaCAYAAAA4qEECAAAACXBIWXMAAAsTAAALEwEAmpwYAAACtElEQVR4nO3du49NURTH8eMVz4ZoEInX4B8Q0Sk1GiIYdHRkEp2OWqMg+ANEIfHINAoJIjEyHqNSKWQwM4SRGGJGhq+czKkk4j72WWvte36ff2DW+t19T85ZZ989RSEiIiIiIiIiIiIiFoB1wDHgKvAQGAe+4usb8AQ4BSzOdiUAi6pwHwC/iG2kXAxFToD5wHFglLyMZLOygW3V1zFXJ4vogMPAFHkbKiIDBjK4DrdiqoiABigioAGKCGiAIgKaYRDoBxYoaBsvgD6taBsTLmHTTM+AhQraxiEFbeOOgrYxrqBtzChoG2MK2sYtBW3jgIKu33D51khB1++MHlhsnw636BHcbu6xWbMOu5Vd//jUqJno6p97eHcYxKCCtjGhoHtl7mHUSHRvFHSvzD2MGoluv4Ku32OTuQfNNgpsqj1kBc1uk5AVNG8167AzpFmHHd11GNF9tBE9GRqZ1l2HjXcK2oau0UYOakXX76npHg9gObAB2AdcBj7R+z6UPZuF/I/glwKngS/07kreWEQBrAcekb9Z4D1wu7wmm28JawWwpPoJWUp93n2FBCyrvm6pDHj3FFa5CoEfiYK+691PaMC5REFPl3c63v2EBayoNgemsNe7n9CYOxwqhUveveRwiNXrBEG/8u4lPOAIaaz17iU0YB7wPEHQ/d69hAfsSRD0Re8+sgDc6zLo+949ZAHYAfzuIuiP3j1kA7jRRdCz3vVnA9gK/Oww6O/e9WcFuNJh0JPetWcFWFMdKxz73IxeAFwIuXml1zB3tnS7XnrXnR1gVwdB3/SuOzvA6g6CPu9dd5aAyTaD1ky6w6CH2wh5pnyRkPzTbgLgWhtBX/euN1vA2TbeGW73rjdbwNEWQi6HUCe8a80asPM/IX/WsD9N0Kv+CrbcBzJW7uOo/kHDyhR/x9sf2G5fDIrarFcAAAAASUVORK5CYII="
								/>
							</defs>
						</svg>
					</button>
					<p class="p-voting-text">Disagree</p>
				</div>
			</div>
		</div>
		<div v-else>
			<div v-if="result !== null">
				<h1 class="h1-votingguide">Results</h1>
				<div class="div-results">
					<!-- <img class="img-pr-d" :src="result.image" /> -->
					<img class="img-pr-p" :src="result.image" />
					<p class="p-votingguide-d">{{ result.text }}</p>
					<p class="p-votingguide-p">{{ result.text }}</p>
				</div>
				<div class="div-button-choose">
					<NuxtLink to="/voting"
						><button class="button-choose-side">Choose a side</button></NuxtLink
					>
				</div>
			</div>
		</div>
	</div>
</template>

<script>
import ProgressBar from "./progressbar.vue";

export default {
	components: {
		ProgressBar,
	},
	data() {
		return {
			questions: [
				{
					title: "Economy",
					text: "In this new economy, vehicles and transportation based on fossil fuels should no longer be allowed.",
				},
				{
					title: "Health Care",
					text: "Healthcare should be free for every individual who lives on the moon.",
				},
				{
					title: "Medical",
					text: "AI-Robots should be allowed to conduct life-threatening surgical operations.",
				},
				{
					title: "Law",
					text: "A law should only be able to be approved by a human politician.",
				},
				{
					title: "Energy Sources",
					text: "All new buildings constructed should be required to incorporate renewable energy sources.",
				},
				{
					title: "Voting",
					text: "Mandatory voting should be implemented to ensure maximum participation in democratic processes.",
				},
				{
					title: "Police arrest",
					text: "Police have the right to be armed and to use force against individuals who are a large threat.",
				},
				{
					title: "GDP expense",
					text: "4% of the society’s GDP should go towards further space exploration.",
				},
				{
					title: "Legal system",
					text: "The legal system should be based on restorative justice principles rather than punitive measures.",
				},
				{
					title: "Family",
					text: "Every couple should have at least two children, if possible, to battle population shrinking and unemployment.",
				},
			],
			userAnswers: [],
			currentQuestion: 0,
			result: null,
			presidents: {
				presidenthuman: [
					"disagree",
					"disagree",
					"disagree",
					"agree",
					"disagree",
					"disagree",
					"disagree",
					"disagree",
					"agree",
					"disagree",
				],
				presidentai: [
					"agree",
					"agree",
					"agree",
					"disagree",
					"agree",
					"agree",
					"agree",
					"agree",
					"disagree",
					"agree",
				],
			},
			progress: 0,
		};
	},
	methods: {
		answerQuestion(answer) {
			this.userAnswers[this.currentQuestion] = answer;
			this.currentQuestion++;
			this.updateProgress();

			if (this.currentQuestion === this.questions.length) {
				this.calculateResult();
			}
		},
		calculateResult() {
			const scores = { presidenthuman: 0, presidentai: 0 };

			this.userAnswers.forEach((answer, index) => {
				if (answer === this.presidents.presidenthuman[index]) {
					scores.presidenthuman++;
				}
				if (answer === this.presidents.presidentai[index]) {
					scores.presidentai++;
				}
			});

			if (scores.presidenthuman > scores.presidentai) {
				this.result = {
					image: "/assets/president-human.png",
					text: "Based on the answers you entered in the voting guide, President Human fits your statements.",
				};
			} else if (scores.presidentai > scores.presidenthuman) {
				this.result = {
					image: "/assets/president-ai.png",
					text: "Based on the answers you entered in the voting guide, President AI fits your statements.",
				};
			} else {
				this.result = {
					image: "/assets/both-presidents.png",
					text: "You align equally with both presidents!",
				};
			}
		},
		updateProgress() {
			this.progress = (this.currentQuestion / this.questions.length) * 100;
		},
	},
};
</script>
