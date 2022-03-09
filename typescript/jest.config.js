/* eslint-env node */
module.exports = {
  setupFilesAfterEnv: ["jest-extended/all"],
  transform: {
    "^.+\\.(t|j)sx?$": "@swc/jest",
  },
};
