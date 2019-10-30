using System;
using com.freeclimb.api;

namespace DeleteRecording {
  class Program {
    static void Main (string[] args) {
      try {
        string freeClimbAccountId = System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
        string freeClimbAccountToken = System.Environment.GetEnvironmentVariable("AUTH_TOKEN");
        string recordingId = "";

        // Create FreeClimbClient object
        FreeClimbClient client = new FreeClimbClient (freeClimbAccountId, freeClimbAccountToken);

        // Invoke deleted method to delete recording Url
        client.getRecordingsRequester.delete (recordingId);
      } catch (FreeClimbException ex) {
        // Exception throw upon failure
        System.Console.WriteLine(ex.Message);
      }
    }
  }
}