﻿#region MIT License

/*
 * Copyright (c) 2012 Kristopher Baker (kris@empyrealnight.com)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

#endregion

namespace Stravan
{
    /// <summary>
    /// Service interface for uploads in the Strava API
    /// </summary>
    public interface IUploadService
    {
        /// <summary>
        /// Provides information on the status of a ride that has been uploaded to the server from a device.
        /// The elapsed_time property is returned as seconds.  The distance property is returned in meters.  
        /// The upload_id is the id of the upload record on the server, and corresponds to the id passed in the request.  
        /// The activity_id is the id of the newly created activity, and should be used to get all the details of the activity in a later API call.  
        /// The id is the file_id of the upload record on the server.
        /// </summary>
        /// <param name="uploadId">Required. The id of the upload (returned from the server when the upload was created).</param>
        /// <param name="token">Required. Authentication token.</param>
        /// <returns>Information on the status of a ride that has been uploaded to the server from a device</returns>
        UploadStatus Status(int uploadId, string token);

        //UploadStatus Upload(string token, 
    }
}
